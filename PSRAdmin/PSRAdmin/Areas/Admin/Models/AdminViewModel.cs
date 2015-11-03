using System;
using System.Web;
using System.ComponentModel.DataAnnotations;    

namespace PSRAdmin.Areas.Admin.Models
{
    public class AdminViewModel
    {
     
        [Required(ErrorMessage="Name is required.")]               
        public string EmployeeName { get; set; }

       
        public string EmployeeAddress { get; set; }
      
    }
}