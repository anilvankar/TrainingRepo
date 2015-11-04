using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PSRAdmin.Models
{
    public class UserViewModel
    {
        [Required]
        public string UserName;

        [RegularExpression("")]
        public string EmailAddress;

        [StringLength(50)]
        public string Address;

        public int UserID;


    }
}