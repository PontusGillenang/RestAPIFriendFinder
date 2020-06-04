using FriendFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class EventDto
    {
        [Required]
        public int EventId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string EventName { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public HobbyDto Hobby { get; set; }
        public CityDto City { get; set; }
        public ICollection<EventUserDto> EventUsers { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}