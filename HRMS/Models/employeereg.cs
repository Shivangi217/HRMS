using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    [Table("employeereg")]
    public class employeereg
    {
        [Key]

        public int ID { get; set; }

        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string gender { get; set; }

        public DateTime bob { get; set; }
        public string nationality { get; set; }
        public string Email { get; set; }
        public string Contact_no { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }




        

    }
}