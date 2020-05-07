
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FriendFinderAPI.Models
{
    public class Match
    {
        
        public int MatchID { get; set; }
        [NotMapped]
         public User MatchedUser1{get;set;}
         [NotMapped]
         public User MatchedUser2{get;set;}
    }
}