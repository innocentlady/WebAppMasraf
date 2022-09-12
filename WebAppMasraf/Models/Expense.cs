using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class Expense
    {
        public Expense()
        {
            ExpenseHistories = new HashSet<ExpenseHistory>();
        }

        public int ExpId { get; set; }
        public int? UExpenseFormId { get; set; }
        public string? Descriptions { get; set; }
        public double? Amount { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string? Isdeleted { get; set; }

        public virtual ExpenseForm? UExpenseForm { get; set; }
        public virtual ICollection<ExpenseHistory> ExpenseHistories { get; set; }
    }
}
