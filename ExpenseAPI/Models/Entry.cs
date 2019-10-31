using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseAPI.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public bool IsExpense { get; set; }
        public double Value { get; set; }
        public string Description { get; set; } 
    }
}