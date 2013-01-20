using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProdocNET.Models
{
    public class ProDocContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Document> Documents { get; set; }
        public DbSet<HistoryEntry> History { get; set; }
    }
}