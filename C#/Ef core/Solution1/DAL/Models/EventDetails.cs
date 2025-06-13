using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("EventDetails")]
    public class EventDetails
    {
        [Key]
        [Column("EventId")]
        public int EventId { get; set; }

        [Column("EventName")]
        [StringLength(50, MinimumLength = 1)]
        public string EventName { get; set; }

        [Column("EventCategory")]
        [StringLength(50, MinimumLength = 1)]
        public string EventCategory { get; set; }

        [Column("EventDate")]
        public DateTime EventDate { get; set; }

        [Column("Description")]
        public string? Description { get; set; }  // Nullable

        [Column("Status")]
        [StringLength(10)]
        public string Status { get; set; }  // Should be "Active" or "In-Active"
    }
}

