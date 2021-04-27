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

        public string GuessID { get; set; }
        public Card Card { get; set; }
        public Category Category { get; set; }
        public int TimeInSeconds { get; set; }
        public int Attempts { get; set; }
        public int NumberOfHelps { get; set; }
        public User UserWhoGuessed { get; set; }

        public Guess(string i_GuessId, Card i_Card, Category i_Category, int i_TimeInSeconds, int i_Attempts, int i_NumberOfHelps, User i_UserWhoGuessed)
        {
            GuessID = i_GuessId;
            Card = i_Card;
            Category = i_Category;
            TimeInSeconds = i_TimeInSeconds;
            Attempts = i_Attempts;
            NumberOfHelps = i_NumberOfHelps;
            UserWhoGuessed = i_UserWhoGuessed;
        }

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
