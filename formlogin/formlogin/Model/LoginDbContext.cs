using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace formlogin.Model
{
    public partial class LoginDbContext : DbContext
    {
        public LoginDbContext()
            : base("name=LoginDbContext")
        {
        }

        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
