using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace queue.Models
{
    public class QueueContext:DbContext
    {
        public QueueContext() : base("QueueContext")
        {

        }
        public DbSet<TableNo> TableNos { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }


    }
}