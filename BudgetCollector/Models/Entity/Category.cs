using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgetCollector.Models
{
    [Table("tblCategory")]
    public class Category
    {
        public int id { get; set; }
        public string kategoriadi { get; set; }
        public string AccountOwner { get; set; }
    }
}