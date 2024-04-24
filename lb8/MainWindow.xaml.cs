using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Richtexteditorsample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TabItem> _tabItems;
        private TabItem _tabAdd;
        
        public MainWindow()
        {
            InitializeComponent();
            cmbfontfamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbfontsize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26,
28, 36, 48, 72 };

            _tabItems = new List<TabItem>();
            _tabAdd = new TabItem();
            _tabAdd.Header = "+";
            _tabItems.Add(_tabAdd);
            this.AddTabItem();
            tabDynamic.DataContext = _tabItems;
            tabDynamic.SelectedIndex = 0;
        }

        private void rtbeditor_Selectionchanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbeditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnbold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnitalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtbeditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            
            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbfontfamily.SelectedItem = temp;
            temp = rtbeditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbfontsize.Text = temp.ToString();
        }
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|all files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream filestream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbeditor.Document.ContentStart,
                rtbeditor.Document.ContentEnd); range.Load(filestream, DataFormats.Rtf);
            }
        }
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|all files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream filestream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbeditor.Document.ContentStart,
                rtbeditor.Document.ContentEnd); range.Save(filestream, DataFormats.Rtf);
            }
        }

        private void cmbfontfamily_Selectionchanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbfontfamily.SelectedItem != null)
                rtbeditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbfontfamily.SelectedItem);
        }
        private void cmbfontsize_Textchanged(object sender, TextChangedEventArgs e)
        {
            rtbeditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbfontsize.Text);
        }
        public TabItem AddTabItem()
        {
            int count = _tabItems.Count;

            TabItem tab = new TabItem();

            tab.Header = string.Format("Tab {0}", count);
            tab.Name = string.Format("tab{0}", count);
            tab.HeaderTemplate = tabDynamic.FindResource("TabHeader") as DataTemplate;

            

            RichTextBox txt = new RichTextBox();
            txt.Name = "rtbeditor1";

            tab.Content = txt;

            _tabItems.Insert(count - 1, tab);

            return tab;

        }
        
        private void tabAdd_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tabDynamic.DataContext = null;
            TabItem tab = this.AddTabItem();
            tabDynamic.DataContext = _tabItems;
            tabDynamic.SelectedItem = tab;
        }
        private void tabDynamic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabItem tab = tabDynamic.SelectedItem as TabItem;
            if (tab == null) return;
            if (tab.Equals(_tabAdd))
            {
                tabDynamic.DataContext = null;
                TabItem newTab = this.AddTabItem();
                tabDynamic.DataContext = _tabItems;
                tabDynamic.SelectedItem = newTab;
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string tabName = (sender as Button).CommandParameter.ToString();
            var item = tabDynamic.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabName)).SingleOrDefault();
            TabItem tab = item as TabItem;
            if (tab != null)
            {
                if (_tabItems.Count < 3)
                {
                    MessageBox.Show("Cannot remove last tab.");
                }
                else if (MessageBox.Show(string.Format("Are you sure you want to remove the tab '{0}'?", 
                    tab.Header.ToString()), "Remove Tab", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    TabItem selectedTab = tabDynamic.SelectedItem as TabItem;
                    tabDynamic.DataContext = null;
                    _tabItems.Remove(tab);
                    tabDynamic.DataContext = _tabItems;
                    if (selectedTab == null || selectedTab.Equals(tab))
                    {
                        selectedTab = _tabItems[0];
                    }
                    tabDynamic.SelectedItem = selectedTab;
                }
            }
        }

        private void btnAddPic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            
            if (dlg.ShowDialog() == true)
            {

                Clipboard.SetImage(new BitmapImage(new Uri(dlg.FileName, UriKind.Relative)));
                rtbeditor.Paste();
                Clipboard.Clear();
            }
        }

        private void btnChangeLang_Click(object sender, RoutedEventArgs e)
        {
            new SelectLanguage().ShowDialog();
        }
    }
}
