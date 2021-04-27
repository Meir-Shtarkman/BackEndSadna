using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;


namespace Classes
{
    public class DualMatch
    {
        public string MatchID { get; set; }
        public string CurrentVideo { get; set; }
        public List<User> PlayersList { get; set; }
        public int PresenterIndex { get; set; }
        public int ResponderIndex { get; set; }
        public Guess Guess { get; set; }
        public List<Card> CardHistoryList { get; set; } //need to change accessesability level
        public int NumberOfRounds { get; set; }

        public DualMatch(string i_MatchId, string i_CurrentVideo, List<User> i_PlayersList, int i_PresenterIndex, int i_ResponderIndex, Guess i_Guess, List<Card> i_CardHistoryList, int i_NumberOfRounds)
        {
            MatchID = i_MatchId;
            CurrentVideo = i_CurrentVideo;
            PlayersList = i_PlayersList;
            PresenterIndex = i_PresenterIndex;
            ResponderIndex = i_ResponderIndex;
            Guess = i_Guess;
            CardHistoryList = i_CardHistoryList;
            NumberOfRounds = i_NumberOfRounds;
        }
        public DualMatch()
        {
            
        }

        public DualMatch(User i_HostUser, User i_OpponentUser)
        {
            MatchID = "dualMatch_" + SystemTools.RandomString();
            PlayersList = new List<User>(2) {i_HostUser, i_OpponentUser};
            PresenterIndex = 0;
            ResponderIndex = 1;
            CardHistoryList = new List<Card>();
            NumberOfRounds = 0;
        }

    }


}
