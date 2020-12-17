using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_API.Model
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }//Id interger input

        public string Customer_Name { get; set; }//to add  Customername
        [Required]
        public string Address { get; set; } // to add address
        [Required]
        public string Customer_Age { get; set; } //to add customer age 
        [Required]
        public string Email { get; set; }//to add email
        
    }
}

