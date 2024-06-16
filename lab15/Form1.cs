using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {   
            FadList.Items.Clear();
            treeView1.Nodes.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text);
            request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            request.Method = Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            try {
                while (!reader.EndOfStream)
                {
                    FadList.Items.Add(reader.ReadLine());
                    treeView1.Nodes.Add(reader.ReadLine());
                }
                MessageBox.Show(response.WelcomeMessage);
                reader.Close();
                response.Close();
            } 
            catch (ObjectDisposedException a) 
            {
                Console.WriteLine("Caught: {0}", a.Message);
            }
                
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Всі файли|*.*|png files|*.png|jpg files|*.jpg|gif " +
                "files | *.gif | bmp files | *.bmp | exe files | *.exe | rar files | *.rar | zip files | *.zip | txt " +
                "files | *.txt";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog1.FileName;
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtUpload + openFileDialog1.SafeFileName);
                    request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                    request.Method = Ftp.UploadFile;
                    byte[] file = System.IO.File.ReadAllBytes(txtPath.Text);
                    Stream strz = request.GetRequestStream();
                    strz.Write(file, 0, file.Length);
                    strz.Close();
                    strz.Dispose();

                    MessageBox.Show(openFileDialog1.SafeFileName + "завантажено");
                }
                else
                {
                    MessageBox.Show(openFileDialog1.SafeFileName + "Не заватажено");
                }
            }
            catch(UriFormatException ex) 
            {
                String err = ex.Message;
                MessageBox.Show(err);
            }
            
        }

        private void btnCreateLog_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtLog.Text);
            request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            request.Method = Ftp.MakeDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Каталог " + txtLog.Text + "створено");

        }//192.168.12.144

        private void btnFileSize_Click(object sender, EventArgs a)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtSize.Text);
            request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            request.Method = Ftp.GetFileSize;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            long size = response.ContentLength;
            MessageBox.Show("Розмір файлу складає " + size/1000000 + " МБ");
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtDeleteFile.Text);
            request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            request.Method = Ftp.DeleteFile;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Файл" + txtDeleteFile.Text + " видалено");
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtDeleteLog.Text);
            request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            request.Method = Ftp.RemoveDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Каталог" + txtDeleteLog.Text + " видалено");
        }
    }
}
