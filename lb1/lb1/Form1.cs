using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace lb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "x = ";
            label2.Text = "y = ";
            label3.Text = "Результат";
            btnOK.Text = "Порахувати";
            label4.Text = "";

            label2_sum.Text = "";
            label2_dif.Text = "";
            label2_prod.Text = "";
            label2_frac.Text = "";
            btn2_OK.Enabled = false;

            label3_bool.Text = "";
            btn3_Check.Enabled = false;

            btn4_OK.Enabled = false;

            label5_res.Text = "";
            btn5_exe.Enabled = false;

            label6_res.Text = "";
            btn6_exe.Enabled = false;

            btn7_exe.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtA.Text);
                double y = Convert.ToDouble(txtB.Text);
                double res = (Math.Exp(x) - ((y * y + 12 * x * y - 3 * x * x) / (18 * y - 1)));
                label4.Text = res.ToString();
            }
            catch
            {
                if (txtA.Text == "")
                {
                    txtA.Focus();
                }
                if (txtB.Text == "")
                {
                    txtB.Focus();
                }
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtA.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtB.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtB.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt2_2_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txt2_2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn2_OK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt2_1_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txt2_1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txt2_2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btn2_OK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txt2_1.Text);
            double y = Convert.ToDouble(txt2_2.Text);
            double sum = x + y;
            double dif = x - y;
            double prod = x * y;
            double frac = x / y;
            label2_sum.Text = Convert.ToString(sum);
            label2_dif.Text = Convert.ToString(dif);
            label2_prod.Text = Convert.ToString(prod);
            label2_frac.Text = Convert.ToString(frac);
        }

        private void txt2_1_TextChanged(object sender, EventArgs e)
        {
            if ((txt2_1.Text.Length == 0) || (txt2_2.Text.Length == 0))
                btn2_OK.Enabled = false;
            else
                btn2_OK.Enabled = true;
        }

        private void txt2_2_TextChanged(object sender, EventArgs e)
        {
            if ((txt2_1.Text.Length == 0) || (txt2_2.Text.Length == 0))
                btn2_OK.Enabled = false;
            else
                btn2_OK.Enabled = true;
        }

        private void btn3_Check_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txt3_1.Text);
            bool isGeometricProgression = IsDigitsInGeometricProgression(number);
            label3_bool.Text = isGeometricProgression.ToString();
        }
        private bool IsDigitsInGeometricProgression(int number)
        {
            int[] digits = new int[3];
            for (int i = 2; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits[1] * digits[1] == digits[0] * digits[2];
        }

        private void txt3_1_TextChanged(object sender, EventArgs e)
        {
            if ((txt3_1.Text.Length == 0))
                btn3_Check.Enabled = false;
            else
                btn3_Check.Enabled = true;
        }

        private void btn4_OK_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt4_a.Text);
            double b = Convert.ToDouble(txt4_b.Text);
            double c = Convert.ToDouble(txt4_c.Text);
            if (a >= b && b >= c && a > c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                c = Math.Abs(c);
            }
            string res = $"a = {a}, b = {b}, c = {c}";
            MessageBox.Show(res, "Результат");
        }

        private void txt4_a_TextChanged(object sender, EventArgs e)
        {
            if ((txt4_a.Text.Length == 0) || (txt4_b.Text.Length == 0) || (txt4_c.Text.Length == 0))
                btn4_OK.Enabled = false;
            else
                btn4_OK.Enabled = true;
        }

        private void txt4_b_TextChanged(object sender, EventArgs e)
        {
            if ((txt4_a.Text.Length == 0) || (txt4_b.Text.Length == 0) || (txt4_c.Text.Length == 0))
                btn4_OK.Enabled = false;
            else
                btn4_OK.Enabled = true;
        }

        private void txt4_c_TextChanged(object sender, EventArgs e)
        {
            if ((txt4_a.Text.Length == 0) || (txt4_b.Text.Length == 0) || (txt4_c.Text.Length == 0))
                btn4_OK.Enabled = false;
            else
                btn4_OK.Enabled = true;
        }

        private void txt4_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txt4_a.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }            
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txt4_a.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txt4_b.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt4_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txt4_b.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txt4_b.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txt4_c.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt4_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txt4_c.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txt4_c.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn4_OK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt3_1_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txt3_1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3_Check.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btn5_exe_Click(object sender, EventArgs e)
        {
            string input = txt5_N.Text;
            string output = input.Replace("1", "");
            label5_res.Text = output;
        }

        private void txt5_N_TextChanged(object sender, EventArgs e)
        {
            if (txt5_N.Text.Length == 0)
                btn5_exe.Enabled = false;
            else
                btn5_exe.Enabled = true;
        }

        private void txt5_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                if (txt5_N.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txt5_N.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn5_exe.Focus();
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txt6_1.Text;
            int t = int.Parse(txt6_2.Text);
            var numbers = input.Split(',').Select(int.Parse).ToList();
            var squares = numbers.Where(number => number == t * t).ToList();
            string output = string.Join(", ", squares);
            label6_res.Text = output;
        }

        private void txt6_1_TextChanged(object sender, EventArgs e)
        {
            if ((txt6_1.Text.Length == 0) || (txt6_2.Text.Length == 0))
                btn6_exe.Enabled = false;
            else
                btn6_exe.Enabled = true;
        }

        private void txt6_2_TextChanged(object sender, EventArgs e)
        {
            if ((txt6_1.Text.Length == 0) || (txt6_2.Text.Length == 0))
                btn6_exe.Enabled = false;
            else
                btn6_exe.Enabled = true;
        }

        private void txt6_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }            
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ' ' || e.KeyChar == ',')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txt6_2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txt6_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn6_exe.Focus();
                return;
            }
            e.Handled = true;
        }

        private void btn7_exe_Click(object sender, EventArgs e)
        {
            string input = txt7_1.Text;
            string output = input.Replace(" ", ", ");
            txt7_2.Text = output;
        }

        private void txt7_1_TextChanged(object sender, EventArgs e)
        {
            if ((txt7_1.Text.Length == 0))
                btn7_exe.Enabled = false;
            else
                btn7_exe.Enabled = true;
        }
    }
}
