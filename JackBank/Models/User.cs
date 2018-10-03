using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JackBank.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public long ID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}