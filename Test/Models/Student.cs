using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Student
    {
        [Key]
        
        public  int  Id{ get; set; }
        public string  Name { get; set; }
        
        [MaxLength(10)]
       
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email is not in corrent formate")]
        public string   Email{ get; set; }
    }
}