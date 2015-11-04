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

        [Required]
        public int Salary;

        [Required]
        public int UserRoleID;

        [Required]
        public string AccountID;

        [Required]
        public string HomeAddress;
    }

    public class TestClass
    {

        public string TestField;
    }
}