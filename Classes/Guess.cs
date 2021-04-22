using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
