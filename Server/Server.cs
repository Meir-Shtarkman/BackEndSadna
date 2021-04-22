using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Server
{
    public class Server: Interface
    {
        private DataStorage Data { get; set; }



        public string Login(string i_Email, string i_Password)
        {
            User user = Data.CheckIfUserExist(i_Email);
            if (user == null)
            {
                return "User not exist in our system";
            }

            if (user.Password.Equals(i_Password))
            {
                return "200";
            }

            return "Wrong Password";
            

        }

        public string CreateUser(User i_NewUser)
        {
            string stringToReturn = Validations.CheckIfUserFiledsAreValid(i_NewUser);
            if(stringToReturn == "200")
            {
                if (Data.InsertUserToTheDataBase(i_NewUser) == "200")
                {
                    return "200";
                }
                else
                {
                    return "The user not enter to the database";
                }
            }
            else
            {
                return stringToReturn;
            }
        }

        public string AddFriend(string i_Email, string i_FriendEmail)
        {
            string messageToReturn = Data.CheckIfFriendIsNotInFriendsList(i_Email, i_FriendEmail);
            if (messageToReturn == "200")
            {
                if (Data.AddFriendToFriendList(i_Email, i_FriendEmail) == "200")
                {
                    return "200";
                }
            }
            return messageToReturn;
        }
        public User OpenDualMode(string i_Email)
        {
            throw new NotImplementedException();
        }

        public string CreateMatch(string i_Email, string i_OpponentEmail)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetDuelMatchDetails(string i_MatchId)
        {
            throw new NotImplementedException();
        }

        public string SendVideo(string i_Category, string i_Card, string i_MatchId)
        {
            throw new NotImplementedException();
        }

        public string SendGuess(Guess i_Guess, string i_MatchId)
        {
            throw new NotImplementedException();
        }

        public string CreateRoom(string i_ManagerEmail)
        {
            throw new NotImplementedException();
        }

        public string JoinRoom(string i_PinNumber, string i_UserEmail)
        {
            throw new NotImplementedException();
        }

        public MultiplayerMatch StartGame(string i_PinNumber)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategory(string i_PinNumber)
        {
            throw new NotImplementedException();
        }

        public string SendCard(string i_Category, string i_Card, string i_PinNumber)
        {
            throw new NotImplementedException();
        }

        public string StartStreaming(string i_PinNumber)
        {
            throw new NotImplementedException();
        }

        public char[] GetStreaming(string i_PinNumber)
        {
            throw new NotImplementedException();
        }

        public MultiplayerMatch GetRoundResult(string i_PinNumber)
        {
            throw new NotImplementedException();
        }
    }
}
