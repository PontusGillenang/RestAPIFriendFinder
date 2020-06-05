using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class Event
    {
        [Required]
        public int EventId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string EventName { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public Hobby Hobby { get; set; }
        public City City { get; set; }
        public ICollection<EventUser> EventUsers { get; set; }
    }
}