using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Samples")]
    public class Samples
    {
        [Key]
        public int LTNumber { get; set; }

        public int SequenceCode { get; set; }

        public int Quantity { get; set; }

        public DateTime DateArrived { get; set; }

        public int EmployeeID { get; set; }

        public DateTime DueDate { get; set; }

        public string Appearance { get; set; }

        public decimal WeightClient { get; set; }

        public decimal WeightActual { get; set; }

        public DateTime ConfirmationSentDate { get; set; }

        public int MaximumToleratedDose { get; set; }

    }

}