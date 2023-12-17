using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Data 
    {
        /* 
          Verilecek Öneri Grupları:
          - Kalacak yer önerisi,
          - Ulaşım önerisi,
          - Aktivite önerisi,        
        

         */
        private static List<string> bodrumOtelItems = new List<string>
            {"Dolphin\r\n",
             "Akkan\r\n",
             "Hotel Bodrum Bay Resort\r\n",
             "Ramada Resort Bodrum\r\n",
             "Azka Otel\r\n",
             "Caresse, a Luxury Collectıon Resort & Spa, Bodrum\r\n",
        };


        public string GetOtel()
        {
            Random random = new Random();

            if (bodrumOtelItems.Count > 0)
            {
                int randomIndex = random.Next(bodrumOtelItems.Count);

                // Seçilen öğeyi yazdırın
                return bodrumOtelItems[randomIndex];
            }
            else
            {
                return "Liste boş.";
            }

        }

        
        

    }
}
