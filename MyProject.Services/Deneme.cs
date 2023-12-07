using Informations;
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
        private Kullanıcı kullanıcı;
        private Data data;
        public string testMesaji;
        int numberPeoplePrefer { get; set; }
        string holiTypePrefer { get; set; }
        string accomTypePrefer { get; set; }
        string transTypePrefer { get; set; }



        public Deneme(Kullanıcı kullanıcı,Data data)
        {
            this.kullanıcı = kullanıcı;
            this.data = data;
            
        }
        


        public void BilgileriAl()
        {
            numberPeoplePrefer = kullanıcı.numberPeopleBoxPrefer;
            holiTypePrefer = kullanıcı.holiholiTypeBoxPrefer;
            accomTypePrefer = kullanıcı.accomTypeBoxPrefer;
            transTypePrefer = kullanıcı.transTypeBoxPrefer;

        }




    }
    

    

}
