using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        public decimal QuotedPrice { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Price { get; set; }

        public decimal Payment { get; set; }

        public int ClientID { get; set; }

        public int StatusID { get; set; }

        public int LTNumber { get; set; }

    }

}