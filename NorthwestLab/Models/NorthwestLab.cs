using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwestLab.Models
{
    public class NorthwestLab
    { 
        public Active active { get; set; }
        public Adjustment adjustment { get; set; }
        public AdjustmentOrders adjustmentOrders { get; set; }
        public Clients clients { get; set; }
        public Compound compound { get; set; }
        public Employees employees { get; set; }
        public Equipment equipment { get; set; }
        public Invoices invoices { get; set; }
        public Material material { get; set; }
        public MaterialTest materialTest { get; set; }
        public Orders orders { get; set; }
        public Required required { get; set; }
        public Samples samples { get; set; }
        public Status status { get; set; }
        public TestEquipment testEquipment { get; set; }
        public TestSample testSample { get; set; }
        public Tests tests { get; set; }



    }
}