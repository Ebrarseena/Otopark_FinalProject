using bil203_Otopark_FinalProject.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bil203_Otopark_FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)  
        {
            txtPassword.PasswordChar = '*'; 
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessCodes bs = new BusinessCodes(); 
            bool sonuc = bs.GirisYap(txtUsername.Text.ToString(), txtPassword.Text.ToString());
            if (sonuc)
            {
                MessageBox.Show("Login Successfull!");  
                Form1 form1 = new Form1();
                form1.Show();   
                this.Hide();   

            }

            else if (txtUsername.Text == "" || txtPassword.Text == "")  
            {
                MessageBox.Show("Please fill in all blank fields!");   
            }


            else  
            {
                MessageBox.Show("They enter incorrectly!"); 
                txtUsername.Clear();    
                txtPassword.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                e.Handled = true;
                button1.PerformClick();  
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongDateString();   

        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {

                txtPassword.PasswordChar = '*';  
            }

            else
            {
                txtPassword.PasswordChar = '\0'; 
            }
        }
    }
}
