using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestLab.DAL
{
    public class NorthwestLabContext : DbContext
    {
        public NorthwestLabContext() : base("NorthwestLabContext")
        {

        }

        public DbSet<Active>Active { get; set; }
        public DbSet<Adjustment> adjustments { get; set; }
        public DbSet<AdjustmentOrders> adjustmentOrders { get; set; }
        public DbSet<Clients> clients { get; set; }
        public DbSet<Compound> compounds { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Equipment> equipment { get; set; }
        public DbSet<Invoices> invoices { get; set; }
        public DbSet<Material> materials { get; set; }
        public DbSet<MaterialTest> MaterialTests { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Required> requireds { get; set; }
        public DbSet<Samples> samples { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<TestEquipment> testEquipment { get; set; }
        public DbSet<TestSample> testSamples { get; set; }
        public DbSet<Tests> tests { get; set; }


    }
}