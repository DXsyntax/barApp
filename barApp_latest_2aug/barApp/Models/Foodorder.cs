using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace barApp.Models
{
    [Table("FOODORDER")]
    public class Foodorder
    {
        [Key]
        public int OrderID { get; set; }
        public string Description { get; set; }
        public string DiningStatus { get; set; }
        public string UserID { get; set; }


    }
}