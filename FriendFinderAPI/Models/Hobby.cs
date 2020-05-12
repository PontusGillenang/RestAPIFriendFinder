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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }
    }
}