using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLab.Models
{
    
        [Table("Status")]
        public class Status
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int StatusID { get; set; }

            public string StatusDescription { get; set; }

        }
    
}