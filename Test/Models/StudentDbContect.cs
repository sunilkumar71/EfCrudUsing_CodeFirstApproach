using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Test.Models
{
    public class StudentDbContect : DbContext
    {

        public StudentDbContect()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentDbContect>());
        }

        public DbSet<Student> Students { get; set; }
    }
}