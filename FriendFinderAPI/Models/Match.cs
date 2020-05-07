using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FriendFinderAPI.Models
{
    public class Match
    {
        
        public int MatchID { get; set; }

        [ForeignKey("UserID1")]
        [InverseProperty("Matches")]
        public User MatchedUser1{get;set;}

        [ForeignKey("UserID2")]
        public User MatchedUser2{get;set;}
    }
}