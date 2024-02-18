using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class Form1 : Form
    {
        public List<Vector> vectors = new List<Vector>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (vectorTextBox.Text == "")
            {
                MessageBox.Show("Введіть вектор у поле") ;
            }
            else
            {
                string[] components = vectorTextBox.Text.Split(',');
                double[] vectorComponents = Array.ConvertAll(components, Double.Parse);
                Vector v = new Vector(vectorComponents);
                vectors.Add(v);

                // Сортуємо список векторів в порядку убування довжин векторів
                vectors.Sort((v1, v2) => v2.Length.CompareTo(v1.Length));

                // Оновлюємо список на формі
                vectorListBox.Items.Clear();
                foreach (Vector vector in vectors)
                {
                    vectorListBox.Items.Add(vector.ToString());
                }
            }
                
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (vectorListBox.SelectedIndex != -1)
            {
                string[] components = vectorTextBox.Text.Split(',');
                double[] vectorComponents = Array.ConvertAll(components, Double.Parse);
                Vector v = new Vector(vectorComponents);
                vectors[vectorListBox.SelectedIndex] = v;
                vectorListBox.Items[vectorListBox.SelectedIndex] = v.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (vectorListBox.SelectedIndex != -1)
            {
                vectors.RemoveAt(vectorListBox.SelectedIndex);
                vectorListBox.Items.RemoveAt(vectorListBox.SelectedIndex);
            }
        }

        private void performOperationButton_Click(object sender, EventArgs e)
        {
            if (vectorListBox.SelectedIndex != -1)
            {
                Vector v = vectors[vectorListBox.SelectedIndex];
                Vector result;
                switch (operationComboBox.SelectedItem.ToString())
                {
                    case "Add":
                        Vector vToAdd = new Vector(Array.ConvertAll(Vector2TextBox.Text.Split(','), Double.Parse));
                        result = v + vToAdd;
                        break;
                    case "Subtract":
                        Vector vToSubtract = new Vector(Array.ConvertAll(Vector2TextBox.Text.Split(','), Double.Parse));
                        result = v - vToSubtract;
                        break;
                    case "Dot Product":
                        Vector vToDotProduct = new Vector(Array.ConvertAll(Vector2TextBox.Text.Split(','), Double.Parse));
                        double dotProduct = v * vToDotProduct;
                        resultTextBox.Text = dotProduct.ToString();
                        return;
                    case "Multiply by Scalar":
                        double scalar = Double.Parse(Vector2TextBox.Text);
                        result = v * scalar;
                        break;
                    case "Length":
                        double length = v.Length;
                        resultTextBox.Text = length.ToString();
                        return;
                    default:
                        return;
                }
                resultTextBox.Text = result.ToString();
            }
        }

        private void vectorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (vectorTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    addButton.Focus();
                return;
            }
            e.Handled = true;
        }

        private void Vector2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (Vector2TextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    performOperationButton.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
