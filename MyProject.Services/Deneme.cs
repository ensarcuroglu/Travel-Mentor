using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace MyProject.Services
{
    public class Deneme 
    {

        private User user;
        
        int numberPeoplePrefer { get; set; }
        string holiTypePrefer { get; set; }    
        string transTypePrefer { get; set; }
        string withWhoPrefer { get; set; }
        string weaPrefer { get; set; }

        string locationPrefer { get; set; }

        public Deneme(User user)
        {
            this.user = user;
            
        }
        


        public void BilgileriAl()
        { 
            numberPeoplePrefer = user.numberPeopleBoxPrefer;
            holiTypePrefer = user.holiholiTypeBoxPrefer;
            transTypePrefer = user.transTypeBoxPrefer;
            withWhoPrefer = user.withWhoBoxPrefer;
            weaPrefer = user.weaPreferBoxPrefer;
            locationPrefer = user.locationBoxPrefer;
        }
        

        public string TercihlereGoreCevap()
        {
            // Önerilerinizi oluşturmak için tercihlerinizi kullanabilirsiniz.
            StringBuilder result = new StringBuilder();
            Data data = new Data();
            // Örnek: "Muğla'da 2 kişi ile Beach Holiday türünde, Villa'da kalmak istiyor, ulaşımı Car ile olacak Spouse or Partner ile ve weaPrefer'ı Sunny olacak."
            // result.AppendLine($"{locationPrefer}’da {numberPeoplePrefer} kişi ile {holiTypePrefer} tatil yapmak için öneriler:");

            switch (holiTypePrefer)
            {
                case ("Beach Holiday"):
                    
                    
                    
                    result.AppendLine("Beach Holiday");
                    break;
                
                
                
                
                
                
                
                default:
                    result.AppendLine("Boş");
                    break;
            }
             


            return result.ToString();
            
            
        }


    }
    

    

}
