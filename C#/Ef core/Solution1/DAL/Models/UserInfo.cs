using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    [Table("UserInfo")]
    public class UserInfo
    {
        //Attribute are a class which is applied over a Property or any other class for setting behaviour 
        [Key]
        [Column("EmailId")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength:100,MinimumLength =2)]
        public string EmailId {  get; set; }

        [Column("UserName")]
        [StringLength(maximumLength:30)]
        public string UserName { get; set; }

        [Column("Role")]
        [StringLength(20)]
        [DefaultValue("Admin")]
        public string Role { get; set; }

        [Column("Password")]
        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }
    }
}
