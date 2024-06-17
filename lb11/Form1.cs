using lb11.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace lb11
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        string imgpath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\bin\\Debug\\Images\\";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MyDatabase.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM TABLE1", conn);
            conn.Open();
            adapter.Fill(dt);
            dgwDatabase.DataSource = dt;
            conn.Close();
            btnClear_Click(this, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            string query = "INSERT INTO TABLE1 (Name, [Phone number], Email, IMG) VALUES (@Name, [@Phone number], @Email, @IMG)";
            cmd = new OleDbCommand(query);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Phone number", txtNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@IMG", txtImg.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Дані додані");
            Form1_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TABLE1 SET Name=@Name, [Phone number]=[@Phone number], Email=@Email, IMG=@IMG WHERE ID=@ID";
            cmd = new OleDbCommand(query);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Phone number", txtNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@IMG", txtImg.Text);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Дані оновлені");
            Form1_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TABLE1 WHERE ID=@ID";
            cmd = new OleDbCommand(query);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Дані видалені");
            Form1_Load(this, null);
        }

        private void dgwDatabase_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgwDatabase.CurrentRow.Cells[0].Value.ToString();
            txtNumber.Text = dgwDatabase.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgwDatabase.CurrentRow.Cells[2].Value.ToString(); 
            txtImg.Text = dgwDatabase.CurrentRow.Cells[3].Value.ToString();
            txtID.Text = dgwDatabase.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtNumber.Text = null;
            txtEmail.Text = null;
            txtImg.Text = null;
            txtID.Text = null;
            txtSearch.Text = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Name LIKE '%" + txtSearch.Text + "%'";
            dgwDatabase.DataSource = dv;
            txtName.Text = null;
            txtNumber.Text = null;
            txtEmail.Text = null;
            txtImg.Text = null;
            txtID.Text = null;
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            openfiledialog1.Title = "Виберіть ілюстрацію";
            openfiledialog1.InitialDirectory = imgpath;
            openfiledialog1.Filter = "фото|*.jpg|все файлы|*.*";
            openfiledialog1.FileName = "";

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                if (openfiledialog1.FileName.ToLower().Contains(openfiledialog1.InitialDirectory.ToLower()) == true)
                {
                    txtImg.Text = openfiledialog1.SafeFileName;
                }
                else
                {
                    try
                    {
                        System.IO.File.Copy(openfiledialog1.FileName, imgpath + openfiledialog1.SafeFileName);
                        txtImg.Text = openfiledialog1.SafeFileName;
                    }
                    catch (Exception ex) 
                    {
                        DialogResult dr;
                        dr = MessageBox.Show(ex.Message + " Замінити його?", "", MessageBoxButtons.OKCancel, 
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.OK)
                        {
                            System.IO.File.Copy(openfiledialog1.FileName, imgpath + openfiledialog1.SafeFileName, true);
                            txtImg.Text = openfiledialog1.SafeFileName;
                        }
                    }
                }
            }
        }

        private void txtImg_TextChanged(object sender, EventArgs e)
        {
            string imagefile;
            string msg;
            if (txtImg.Text.Length == 0)
            {
                imagefile = imgpath + "\\nobody.jpg";
            }
            else
                imagefile = imgpath + txtImg.Text;
            try
            {
                msg = "";
                pictureBox1.Image = Image.FromFile(imagefile);
            }
            catch (System.IO.FileNotFoundException)
            {
                msg = "File nof found: " + imagefile;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
                MessageBox.Show(msg);
            }

        }

        private void txtImg_Leave(object sender, EventArgs e)
        {
            string imagefile;
            string msg;
            if (txtImg.Text.Length == 0)
            {
                imagefile = imgpath + "\\nobody.jpg";
            }
            else
                imagefile = imgpath + txtImg.Text;
            try
            {
                msg = "";
                pictureBox1.Image = Image.FromFile(imagefile);
            }
            catch (System.IO.FileNotFoundException)
            {
                msg = "File nof found: " + imagefile;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
                MessageBox.Show(msg);
            }
        }
    }
}
