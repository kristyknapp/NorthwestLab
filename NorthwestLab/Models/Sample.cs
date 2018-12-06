using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    public class sample
    {
        [Key]
        public int id { get; set; }
        public int ClientID { get; set; }
        public int OrderID { get; set; }
        public int LTNumber { get; set; }
        public int TestID { get; set; }
        public string Result { get; set; }
    }
}