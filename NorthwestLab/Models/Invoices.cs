using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Total { get; set; }

        public DateTime EarlyPaymentDate { get; set; }

        public int OrderID { get; set; }

        public int ClientID { get; set; }

        public decimal EarlyPaymentDiscount { get; set; }

    }

}