using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol_new
{
    class Peyment
    {

        
        public int CartId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string Card3DSecurity { get; set; }


        public Peyment()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Kart novu: " + this.CardName + "\n");
            info.Append("kart nomresi: " + this.CardNumber + "\n");
            info.Append("Novu: " + this.CardType + "\n");
            info.Append("3D tehlukesizlik: " + this.Card3DSecurity + "\n");
            Console.WriteLine(info);

        }

       
    }

    }    
    

