using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS.Models
{
    [Table("Department")]
    public class empdepartment
    {

        [Key]

        public string Department { get; set; }

        public int Id { get; set; }
    }
}