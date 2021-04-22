using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class MultiplayerMatch
    {
       private string MultiplayerMatchID { get; set; }
       private List<User> PlayersList { get; set; }
       private List<Round> RoundsList { get; set; }
       private List<int> ScoreList { get; set; }

    }
}
