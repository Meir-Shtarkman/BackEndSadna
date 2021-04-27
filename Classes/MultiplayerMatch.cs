using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
    public class MultiplayerMatch
    {
       private string MultiplayerMatchID { get; set; }
       private List<User> PlayersList { get; set; }
       private List<Round> RoundsList { get; set; }
       private List<int> ScoreList { get; set; }

       public MultiplayerMatch(string i_MultiplayerMatchId, List<User> i_PlayersList, List<Round> i_RoundsList, List<int> i_ScoreList)
       {
           MultiplayerMatchID = i_MultiplayerMatchId;
           PlayersList = i_PlayersList;
           RoundsList = i_RoundsList;
           ScoreList = i_ScoreList;
       }

       public MultiplayerMatch(List<User> i_PlayersList, List<Round> i_RoundsList, List<int> i_ScoreList)
       {
           MultiplayerMatchID = "multiplayerMatch_" + SystemTools.RandomString();
           PlayersList = i_PlayersList;
           RoundsList = i_RoundsList;
           ScoreList = i_ScoreList;
       }
    }
}
