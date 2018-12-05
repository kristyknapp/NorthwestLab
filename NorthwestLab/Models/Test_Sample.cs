using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace NorthwestLab.Models
{
    [Table("Test_Sample")]
    public class TestSample
    {
        [Key]
        public int TestID { get; set; }

        public int LTNumber { get; set; }

        public int SequenceCode { get; set; }

        public string Result { get; set; }

        public string AnalysisReport { get; set; }

    }
}