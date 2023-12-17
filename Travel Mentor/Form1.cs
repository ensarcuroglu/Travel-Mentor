using MyProject.Services;
using System.Security.Cryptography.X509Certificates;

namespace Travel_Mentor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            user = new User();
        }

        private User user;

        private void AddItemsToComboBox(ComboBox comboBox, string[] items)
        {
            comboBox.Items.AddRange(items);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Screen login_Screen = new Login_Screen();
            welcomeLabel.Text = "Welcome, " + login_Screen.user_name;
            
            

            string[] locationItems = {"Bodrum", "Dalaman", "Akyaka", "Marmaris", "Fethiye" };

            string[] peopleItems = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            string[] holiTypeItems =
                {
                "Beach Holiday",
                "Mountain Holiday",
                "Cultural Holiday",
                "Adventure Trip",
                "Winter Vacation",
                "Nature Getaway",
                "Culinary Tour",
                "Camping Adventure",
                "Hiking and Trekking Expedition",
                "Honeymoon Getaway",
                "Family Vacation",
                "Romantic Escape",
                "Discovery Vacation"};

            string[] transTypeItems =
                {
                "Car",
                "Taxi",
                "Train",
                "Bus",
                "Plane",
                "Ship",
                "Rental Car"};

            string[] withWhoItems =
                {
                "Family",
                "Friends",
                "Spouse or Partner"};

            string[] weaPreferItems =
                {
                "Sunny",
                "Partly Cloudy",
                "Cloudy",
                "Rainy",
                "Karlý"};

            AddItemsToComboBox(numberPeopleBox, peopleItems);
            AddItemsToComboBox(locationBox, locationItems);
            AddItemsToComboBox(holiTypeBox, holiTypeItems);
            AddItemsToComboBox(transTypeBox, transTypeItems);
            AddItemsToComboBox(withWhoBox, withWhoItems);
            AddItemsToComboBox(weaPreferBox, weaPreferItems);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numberPeopleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberPeopleBox.SelectedItem != null)
            {
                user.numberPeopleBoxPrefer = int.Parse(numberPeopleBox.SelectedItem.ToString());
            }
            

        }

        private void holiTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(holiTypeBox.SelectedItem != null)
            {
                user.holiholiTypeBoxPrefer = holiTypeBox.Text;            
            }                    
        
        }

        private void transTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(transTypeBox.SelectedItem != null)
            {
                user.transTypeBoxPrefer = transTypeBox.Text;
            }    
                     
        }
        private void withWhoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (withWhoBox.SelectedItem != null)
            {
                user.withWhoBoxPrefer = withWhoBox.Text;
            }
            
        }

        private void weaPreferBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weaPreferBox.SelectedItem != null)
            {
                user.weaPreferBoxPrefer = weaPreferBox.Text;
            }
            
        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locationBox.SelectedItem != null)
            {
                user.locationBoxPrefer = locationBox.Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Deneme deneme = new Deneme(user);
            Data data = new Data();

            if (txtBudget != null && int.TryParse(txtBudget.Text, out int budgetValue))
            {
                user.Budget = int.Parse(txtBudget.Text);
            }
            else
            {
                MessageBox.Show("Bakiye'yi hatalý girdiniz.");
            }

            deneme.BilgileriAl();
            string result = deneme.TercihlereGoreCevap();
            string gelenotel = data.GetOtel();
            txtTest.Text = gelenotel + user.Budget;

        }
    }
}