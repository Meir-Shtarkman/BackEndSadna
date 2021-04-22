using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Round
    {
        private string RoundID { get; set; }
        private List<Guess> GuessList { get; set; }
        private int RoundNumber { get; set; }
        private User Presenter { get; set; }
        private List<int> ScoreList { get; set; }

    }
}
