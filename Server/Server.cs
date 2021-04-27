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
        public DataStorage Data { get; set; }
        public List<string> OnlineUserIds { get; set; }

        // Check if User Exist and if so LogIn, Return status to the Client.
        public string Login(string i_Email, string i_Password)
        {
            User user = Data.CheckIfUserExist(i_Email);
            if (user == null)
            {
                return "User not exist in our system";
            }

            if (user.Password.Equals(i_Password))
            {
                OnlineUserIds.Add(user.Email);
                return "200";
            }

            return "Wrong Password";
            

        }

        // Create new user and return the status of the request to client
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

        // return the User object to the client.
        public User OpenDualMode(string i_Email)
        {
            // maybe we need to decide which part of the data we will sent here
            return Data.CheckIfUserExist(i_Email);
        }

        // Create new Duel match with friend and return the match object to client.
        public DualMatch CreateMatch(string i_Email, string i_OpponentEmail)
        {
            User hostUser = Data.CheckIfUserExist(i_Email);
            User opponentUser = Data.CheckIfUserExist(i_OpponentEmail);
            DualMatch newMatch = new DualMatch(hostUser, opponentUser);
            Data.UpdateUserMatches(i_Email, newMatch);
            Data.UpdateUserMatches(i_OpponentEmail, newMatch);

            return newMatch;
        }

        public List<Category> GetDuelMatchDetails(string i_MatchId)
        {
            DualMatch currentMatch = Data.GetDualMatchById(i_MatchId);
            
            List<Category> filteredCategories = new List<Category>();
            foreach (Category category in Data.Categories)
            {
                filteredCategories.Add(category.GetFilteredCategory(currentMatch.CardHistoryList));
            }

            return filteredCategories;
        }

        public string SendVideo(string i_CategoryId, string i_CardId, string i_MatchId, string i_UserId, string i_Video)
        {
           //get objects from the ID

            Card currentCard = Data.GetCardById(i_CardId);
            Category currentCategory = Data.GetCategotyById(i_CategoryId);

            Guess guess =
                new Guess(currentCard, currentCategory,Data.CheckIfUserExist(i_UserId));
            //send to data base to update
            //should return if the update successed

            return Data.UpdateMatchSender(i_MatchId, currentCard, guess, i_Video);

        }

        public string SendGuess(Guess i_Guess, string i_MatchId)
        {

            // save guess in database
           return Data.UpdateMatchResponder(i_MatchId);
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
