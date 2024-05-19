using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));


        }
        Thread thread1;
        Thread thread2;
        Thread thread3;
        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width),
                   rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i =>
                {
                    richTextBox1.Invoke((MethodInvoker)delegate ()
                    {
                        richTextBox1.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //draw_eclips();
            //draw_rect();
            //Rnd_num();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            thread1.Abort();
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            thread2.Abort();
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            thread3.Abort();
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        public static byte[] GenerateSecureKey()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[16];
                randomNumberGenerator.GetBytes(key);
                return key;
            }
        }

        private async Task BlockEncryptionMethod(string input)
        {
            int[] key = { 3, 1, 4, 2 };

            for (int i = 0; i < input.Length % key.Length; i++)
                input += input[i];

            string result = "";
            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];
                for (int j = 0; j < key.Length; j++)
                    transposition[key[j] - 1] = input[i + j];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }
            richTextBox3.Text += result + "\r\n";

        }

        private async Task HashingMethod(string input)
        {
            await Task.Run(() =>
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    richTextBox2_2.Text += "Hash: " + builder.ToString() + "\r\n";
                }
                richTextBox2_2.Text += "Hashing method finished" + "\r\n";
            });
        }

        private async Task RandomNumberGenerationMethod()
        {
            await Task.Run(() =>
            {
                Random random = new Random();
                richTextBox2.Text += random.Next().ToString();
                Console.WriteLine("Random number generation method finished");
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            var task1 = BlockEncryptionMethod(input);
            var task2 = HashingMethod(input);
            var task3 = RandomNumberGenerationMethod();

            await Task.WhenAll(task1, task2, task3);

            MessageBox.Show("Finished");
        }
    }
}
