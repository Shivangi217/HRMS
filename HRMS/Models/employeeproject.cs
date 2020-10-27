using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    [Table("empproject")]
    public class employeeproject
    {  

            [Key]
            public int Id { get; set; }
            public int empid { get; set; }
            public string project { get; set; }

       
    }
}