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
        private EnumLevel Level { get; set; } 
        private int Experience { get; set; }
        private int Coins { get; set; }
        private List<DualMatch> ActiveMatchList { get; set; }
        private string Picture { get; set; }
        private string FacebookAccessKey { get; set; }

    }
}
