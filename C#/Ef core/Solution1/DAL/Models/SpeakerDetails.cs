using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("SpeakersDetails")]
    public class SpeakersDetails
    {
        [Key]
        [Column("SpeakerId")]
        public int SpeakerId { get; set; }

        [Column("SpeakerName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 1)]
        public string SpeakerName { get; set; }
    }
}

