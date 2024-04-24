using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Richtexteditorsample
{
    /// <summary>
    /// Interaction logic for SelectLanguage.xaml
    /// </summary>
    public partial class SelectLanguage : Window
    {
        public SelectLanguage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Concat("Restart the application for changes to apply"));
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb.SelectedIndex == 0)
                Properties.Settings.Default.LanguageCode = "en";
            else
                Properties.Settings.Default.LanguageCode = "uk";
            Properties.Settings.Default.Save();
        }
    }
}
