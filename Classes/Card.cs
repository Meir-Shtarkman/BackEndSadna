using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
    public class Card
    {
        public string CardID { get; set; } //need to change accessesability level
        public string Name { get; set; }
        public int DificultLevel { get; set; }


        public Card(string i_CardID, string i_Name ,int i_DificultLevel)
        {
            CardID = i_CardID;
            Name = i_Name;
            DificultLevel = i_DificultLevel;
        }

        public Card(string i_Name, int i_DificultLevel)
        {
            CardID = "card_" + SystemTools.RandomString();
            Name = i_Name;
            DificultLevel = i_DificultLevel;
        }



    }
    
    

}
