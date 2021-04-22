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
        private List<User> Users { get; set; }
        private List<Room> Rooms { get; set; }
        private List<Category> Categories { get; set; }

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
       

        public Category GetCategory()
        {

        } 
    }
   
}
