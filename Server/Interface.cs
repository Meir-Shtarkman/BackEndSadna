using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface Interface
    {
        string Login(string i_Email, string i_Password);
        string CreateUser(User i_NewUser);
        string AddFriend(string i_Email, string i_FriendEmail);


        User OpenDualMode(string i_Email);
        string CreateMatch(string i_Email, string i_OpponentEmail);
        List<Category> GetDuelMatchDetails(string i_MatchId);
        string SendVideo(string i_Category, string i_Card, string i_MatchId);
        string SendGuess(Guess i_Guess, string i_MatchId);



        string CreateRoom(string i_ManagerEmail);
        string JoinRoom(string i_PinNumber, string i_UserEmail);
        MultiplayerMatch StartGame(string i_PinNumber);
        List<Category> GetCategory(string i_PinNumber);
        string SendCard(string i_Category, string i_Card, string i_PinNumber);
        string StartStreaming(string i_PinNumber);
        char[] GetStreaming(string i_PinNumber);
        MultiplayerMatch GetRoundResult(string i_PinNumber);

    }
}
