namespace Travel_Mentor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Screen login_Screen = new Login_Screen();
            welcomeLabel.Text = "Welcome, " + login_Screen.user_name;


        }

        
    }
}