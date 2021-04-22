using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DualMatch
    {
        private string MatchID { get; set; }
        private string CurrentVideo { get; set; }
        private List<User> PlayersList { get; set; }
        private int PresenterIndex { get; set; }
        private int ResponderIndex { get; set; }
        private Guess Guess { get; set; }
        public List<Card> CardHistoryList { get; set; } //need to change accessesability level
        private int NumberOfRounds { get; set; }
    }


}
