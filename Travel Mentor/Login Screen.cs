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

        }


        string user_name = "ensarcuroglu";

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name == usernameText.Text)
            {
                
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Visible = false;



            }
            else
            {
                MessageBox.Show("Kullanıcı Adı hatalı. Lütfen tekrar deneyiniz.");
            }

            




        }
    }
}
