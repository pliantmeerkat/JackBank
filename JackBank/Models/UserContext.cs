using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JackBank.Models
{
    public class UserContext :DbContext
    {
        public UserContext() : base(nameOrConnectionString: "JackBankDev") { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Users");
            base.OnModelCreating(modelBuilder);
        }
    }
}