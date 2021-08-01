using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace barApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("conn") { }
        public DbSet<Account> ACCOUNT { get; set; }
        public DbSet<Foodorder> FOODORDER { get; set; }
    }
}