using Informations;

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

            Data data = new Data();
            
            // Location Items Added
            List<string> itemsLocation = data.GetLocationItems();
            locationBox.Items.AddRange(itemsLocation.ToArray());

            // Location Items Added
            List<string> itemsPeople = data.GetPeopleItems();
            numberPeopleBox.Items.AddRange(itemsPeople.ToArray());

            // Holiday Type Added
            List<string> itemsHoliType = data.GetHoliTypeItems();
            holiTypeBox.Items.AddRange(itemsHoliType.ToArray());

            // Accommodation Type Added
            List<string> itemsAccomType = data.GetAccomTypeItems();
            accomTypeBox.Items.AddRange(itemsAccomType.ToArray());

            // Transportation Type Added
            List<string> itemsTransType = data.GetTransTypeItems();
            transTypeBox.Items.AddRange(itemsTransType.ToArray());

            // Activity Added
            List<string> itemsActivity = data.GetActivityItems();
            activityListBox.Items.AddRange(itemsActivity.ToArray());

            // With Whom Added
            List<string> itemsWithWho = data.GetWithWhoItems();
            withWhoBox.Items.AddRange(itemsWithWho.ToArray());

            // Weather Prefer Added
            List<string> itemsWeaPrefer = data.GetWeaPrefer();
            weaPreferBox.Items.AddRange(itemsWeaPrefer.ToArray());

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}