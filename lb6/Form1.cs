namespace lb6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(txtX1.Text);
                double y1 = Convert.ToDouble(txtY1.Text);
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double C = Convert.ToDouble(txtC.Text);

                if (A == 0 && B == 0)
                {
                    throw new Exception("A та B не можуть дорівнювати 0.");
                }

                double D = Math.Abs(A * x1 + B * y1 + C) / Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

                MessageBox.Show($"Відстань від точки P1({x1}, {y1}) до прямої {A}x + {B}y + {C} = 0 дорівнює {D}.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть дійсні числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }
    }
}