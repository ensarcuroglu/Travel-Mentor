using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Travel_Mentor
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            labelemail.Visible = false;
            emailText.Visible = false;
            loginCheckBox.Checked = true;
            
        }


        public string user_name = "ensarcuroglu";
        string password = "Ensar123";
        
        void clearText()
        {
            usernameText.Clear();
            passwordText.Clear();
            emailText.Clear();
        }
        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user_name == usernameText.Text && password == passwordText.Text)
            {
                
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Visible = true;
                

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı hatalı. Lütfen tekrar deneyiniz.");
                clearText();
            }

        }

        private void registerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (registerCheckBox.Checked)
            {
                emailText.Visible = true;
                labelemail.Visible = true;
                btnLogin.Text = "Register";
                loginCheckBox.Checked = false;
                clearText();
            }
            else
            {
                emailText.Visible = false;
                labelemail.Visible = false;
                btnLogin.Text = "Login";
                loginCheckBox.Checked = true;
            }
        }

        private void loginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loginCheckBox.Checked)
            {
                emailText.Visible = false;
                labelemail.Visible = false;
                btnLogin.Text = "Login";
                registerCheckBox.Checked = false;
                clearText();

            }
            else
            {
                emailText.Visible = true;
                labelemail.Visible = true;
                btnLogin.Text = "Register";
                registerCheckBox.Checked = true;
            }

        }
    }
}
