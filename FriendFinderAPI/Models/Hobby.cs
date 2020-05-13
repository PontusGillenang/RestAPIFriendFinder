using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public enum HobbyActivationLevel 
        {
            Beginner,
            Intermediate,
            Skilled,
            Expert
        }
    public class Hobby
    {
        public HobbyActivationLevel HobbyActivationLevel{get;set;}
       
        [Key]
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Location> HobbyLocations { get; set; }

    }
}