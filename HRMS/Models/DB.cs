using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HRMS.Models
{
    public class DB: DbContext
    {
        public DB(): base("name=shivu")
        {


        }

        
        public DbSet<employeereg> employeeregs { get; set; }

        public DbSet<empdepartment> empdepartments { get; set; }

        
    }
}