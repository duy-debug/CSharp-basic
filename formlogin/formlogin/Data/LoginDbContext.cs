using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace formlogin.Data
{
    public partial class LoginDbContext : DbContext
    {
        public LoginDbContext()
            : base("name=LoginDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
