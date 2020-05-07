
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class User
    {
      
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserAdress { get; set; }
        public string UserPhoneNumber { get; set; }
        public int UserAge { get; set; }
        public bool UserIsTeacher { get; set; }
        public ICollection<Hobby> Hobbies { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}