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

    }
}
