using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Room
    {
     private string RoomID { get; set; }
     private string RoomPinCode { get; set; }
     private List<User> Users { get; set; }
     private List<User> Managers { get; set; }
     private Chat chat { get; set; }
     private MultiplayerMatch CurrentMatch { get; set; }
     //settings(?)
     //max number of users
     private List<Card> CardsHistory { get; set; }
    }
}
