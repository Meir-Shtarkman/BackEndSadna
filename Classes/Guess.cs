using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
   public class Guess
    {

        private string GuessID { get; set; }
        private Card Card { get; set; }
        private Category Category { get; set; }
        private int TimeInSeconds { get; set; }
        private int Attempts { get; set; }
        private int NumberOfHelps { get; set; }
        private User UserWhoGuessed { get; set; }

       public Guess(Card i_Card, Category i_Category, User i_User)
       {
           GuessID = "Guess_" + SystemTools.RandomString();
           Card = i_Card;
           Category = i_Category;
           UserWhoGuessed = i_User;
           NumberOfHelps = 0;
           Attempts = 0;
           TimeInSeconds = 0;
       }

    }
}
