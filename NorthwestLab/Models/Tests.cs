using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    [Table("Tests")]
    public class Tests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestID { get; set; }

        [Required(ErrorMessage = "")]
        public string Type { get; set; }

        [Required(ErrorMessage = "")]
        public string TestDescription { get; set; }

        [Required(ErrorMessage = "")]
        public DateTime DurationEstimate { get; set; }

        [Required(ErrorMessage = "")]
        public int RequiredID { get; set; }

        [Required(ErrorMessage = "")]
        public decimal Cost { get; set; }
    }



}