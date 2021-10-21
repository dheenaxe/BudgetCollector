using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgetCollector.Models
{
    [Table("tblAccount")]

    public class Account
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
    }
}