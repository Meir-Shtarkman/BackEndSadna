using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Server
{
    public class DataStorage
    {
        public List<User> Users { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Category> Categories { get; set; }
        public List<Card> Cards { get; set; }
        public List<DualMatch> DualMatches { get; set; }

        public DualMatch GetDualMatchById(string i_Id)
        {
            foreach (DualMatch dualMatch in DualMatches)
            {
                if (dualMatch.MatchID.Equals(i_Id))
                {
                    return dualMatch;
                }
            }

            return null;
        }

        public void GetMoviesFromFile()
        {
            List<Card> cards = new List<Card>(100);

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\micha\source\repos\BackEndMTAProject\movies.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
                Cards.Add(new Card(line,1));
            }

            Categories = new List<Category>();
            Categories.Add(new Category("Movies",cards));

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }

        public User CheckIfUserExist(string i_Email)
        {
            foreach (User user in Users)
            {
                if (user.Email.Equals(i_Email))
                {
                    return user;
                }
            }

            return null;
        }

        internal string InsertUserToTheDataBase(User i_NewUser)
        {
            Users.Add(i_NewUser);
            return "200";
        }

        public string CheckIfFriendIsNotInFriendsList(string i_Email, string i_FriendEmail)
        {
            foreach(User user in Users)
            {
                if (user.Email.Equals(i_Email))
                {
                    foreach(User friend in user.FriendsList)
                    {
                        if (friend.Email.Equals(i_FriendEmail))
                        {
                            return "Friend is already exist";
                        }
                    }
                }
            }
            return "200"; // friend does not exist
        }

        internal string AddFriendToFriendList(string i_Email, string i_FriendEmail)
        {
            User user = CheckIfUserExist(i_Email);
            if (user != null)
            {
                User friend = CheckIfUserExist(i_FriendEmail);
                if (friend != null)
                {
                    user.FriendsList.Add(friend);
                    return "200";
                }
            }
            return "error";
        }
        

        public void UpdateUserMatches(string i_Email, DualMatch i_NewMatch)
        {
            User user = CheckIfUserExist(i_Email);
            user.ActiveMatchList.Add(i_NewMatch);
        }

        public Card GetCardById(string i_CardId)
        {
            foreach (Card card in Cards)
            {
                if (card.CardID.Equals(i_CardId))
                {
                    return card;
                }
            }

            return null;
        }

        public Category GetCategotyById(string i_CategoryId)
        {
            foreach (Category category in Categories)
            {
                if (category.CategoryID.Equals(i_CategoryId))
                {
                    return category;
                }
            }

            return null;
        }

        public string UpdateMatchSender(string currentMatchID, Card currentCard, Guess guess, string video)
        {
            DualMatch currentMatch = GetDualMatchById(currentMatchID);
            currentMatch.CardHistoryList.Add(currentCard);
            currentMatch.Guess = guess;
            currentMatch.CurrentVideo = video;
            //switch presenter and responder indexes
            SwitchUsersIndex(currentMatch);
            currentMatch.NumberOfRounds++;
            //update dual match in the data base
            for (int i = 0; i < DualMatches.Count; i++)
            {
                if (DualMatches[i].MatchID.Equals(currentMatch.MatchID))
                {
                    DualMatches[i] = currentMatch;
                    // return "the match is updated";
                    return "seccess";
                }
            }
            return "failed";
            //return failed
        }

        public string UpdateMatchResponder(string i_MatchId)
        {
            DualMatch currentMatch = GetDualMatchById(i_MatchId);
            SwitchUsersIndex(currentMatch);
            return "success";
        }

        public void SwitchUsersIndex(DualMatch currentMatch)
        {
            if (currentMatch.PresenterIndex == 0)
            {
                currentMatch.PresenterIndex = 1;
                currentMatch.ResponderIndex = 0;
            }
            else
            {
                currentMatch.PresenterIndex = 0;
                currentMatch.ResponderIndex = 1;
            }
        }
    }
   
}
