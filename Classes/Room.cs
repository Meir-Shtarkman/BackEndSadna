using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

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

     public Room(string i_RoomId, string i_RoomPinCode, List<User> i_Users, List<User> i_Managers, Chat i_Chat, MultiplayerMatch i_CurrentMatch, List<Card> i_CardsHistory)
     {
         RoomID = i_RoomId;
         RoomPinCode = i_RoomPinCode;
         Users = i_Users;
         Managers = i_Managers;
         chat = i_Chat;
         CurrentMatch = i_CurrentMatch;
         CardsHistory = i_CardsHistory;
     }

     public Room(string i_RoomPinCode, List<User> i_Users, List<User> i_Managers, Chat i_Chat, MultiplayerMatch i_CurrentMatch, List<Card> i_CardsHistory)
     {
         RoomID = "room_" + SystemTools.RandomString();
         RoomPinCode = i_RoomPinCode;
         Users = i_Users;
         Managers = i_Managers;
         chat = i_Chat;
         CurrentMatch = i_CurrentMatch;
         CardsHistory = i_CardsHistory;
     }
    }
}
