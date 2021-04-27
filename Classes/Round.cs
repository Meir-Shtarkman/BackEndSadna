using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
    public class Round
    {
        private string RoundID { get; set; }
        private List<Guess> GuessList { get; set; }
        private int RoundNumber { get; set; }
        private User Presenter { get; set; }
        private List<int> ScoreList { get; set; }

        public Round(string i_RoundId, List<Guess> i_GuessList, int i_RoundNumber, User i_Presenter, List<int> i_ScoreList)
        {
            RoundID = i_RoundId;
            GuessList = i_GuessList;
            RoundNumber = i_RoundNumber;
            Presenter = i_Presenter;
            ScoreList = i_ScoreList;
        }

        public Round(List<Guess> i_GuessList, int i_RoundNumber, User i_Presenter, List<int> i_ScoreList)
        {
            RoundID = "round_" + SystemTools.RandomString();
            GuessList = i_GuessList;
            RoundNumber = i_RoundNumber;
            Presenter = i_Presenter;
            ScoreList = i_ScoreList;
        }


    }
}
