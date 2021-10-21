using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgetCollector.Models
{
    [Table("tblBudget")]
    public class Budget
    {
        public int id { get; set; }
        public DateTime Time { get; set; }
        public string AccountOwner { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
    }
}