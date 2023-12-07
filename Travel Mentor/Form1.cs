using Informations;
using MyProject.Services;
using System.Security.Cryptography.X509Certificates;

namespace Travel_Mentor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kullan�c� = new Kullan�c�();
        }

        private Kullan�c� kullan�c�;


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

        private void numberPeopleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberPeopleBox.SelectedItem != null)
            {
                kullan�c�.numberPeopleBoxPrefer = int.Parse(numberPeopleBox.SelectedItem.ToString());
            }
            

        }

        private void holiTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(holiTypeBox.SelectedItem != null)
            {
                kullan�c�.holiholiTypeBoxPrefer = holiTypeBox.Text;            
            }                    
        
        }

        private void accomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(accomTypeBox.SelectedItem != null)
            {
                kullan�c�.accomTypeBoxPrefer = accomTypeBox.Text;
            }
                        
        }

        private void transTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(transTypeBox.SelectedItem != null)
            {
                kullan�c�.transTypeBoxPrefer = transTypeBox.Text;
            }    
                     
        }

        private void activityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // YAPILACAK !!
        }

        private void withWhoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (withWhoBox.SelectedItem != null)
            {
                kullan�c�.withWhoBoxPrefer = withWhoBox.Text;
            }
            
        }

        private void weaPreferBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaPreferBox.SelectedItem != null)
            {
                kullan�c�.weaPreferBoxPrefer = weaPreferBox.Text;
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            Deneme deneme = new Deneme(kullan�c�,data);
            deneme.BilgileriAl();          
            kullan�c�.Budget = int.Parse(txtBudget.Text);
            test.Text = kullan�c�.Budget.ToString();

        }
    }
}