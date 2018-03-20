using AssetManagement.Models.AssetManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssetManagement.Data
{
    public class AppContext: DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}