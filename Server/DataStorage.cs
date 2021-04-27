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
    }
   
}
