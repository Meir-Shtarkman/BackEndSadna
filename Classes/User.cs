using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class User
    {
        public string Name { get; set; }  //need to change the accessability level
        public string Email { get; set; } //need to change the accessability level
        public string Password { get; set; } //need to change the accessability level
        public List<User> FriendsList { get; set; } //need to change the accessability level
        public EnumLevel Level { get; set; }
        public int Experience { get; set; }
        public int Coins { get; set; }
        public List<DualMatch> ActiveMatchList { get; set; }
        public string Picture { get; set; }
        public string FacebookAccessKey { get; set; }

        public User(string i_Name, string i_Email, string i_Password, List<User> i_FriendsList, EnumLevel i_Level, int i_Experience, int i_Coins, List<DualMatch> i_ActiveMatchList, string i_Picture, string i_FacebookAccessKey)
        {
            Name = i_Name;
            Email = i_Email;
            Password = i_Password;
            FriendsList = i_FriendsList;
            Level = i_Level;
            Experience = i_Experience;
            Coins = i_Coins;
            ActiveMatchList = i_ActiveMatchList;
            Picture = i_Picture;
            FacebookAccessKey = i_FacebookAccessKey;
        }

        public User(string i_Name, string i_Email, string i_Password, List<User> i_FriendsList, string i_Picture, string i_FacebookAccessKey)
        {
            Name = i_Name;
            Email = i_Email;
            Password = i_Password;
            FriendsList = i_FriendsList;
            Picture = i_Picture;
            FacebookAccessKey = i_FacebookAccessKey;
        }

    }
}
