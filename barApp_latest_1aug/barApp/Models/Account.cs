using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // added in
using System.Linq;
using System.Web;

namespace barApp.Models
{
    [Table("ACCOUNT")]
    public class Account
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}