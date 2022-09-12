using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class ExpenseStatus
    {
        public ExpenseStatus()
        {
            ExpenseFormHistories = new HashSet<ExpenseFormHistory>();
            ExpenseForms = new HashSet<ExpenseForm>();
            ExpenseHistories = new HashSet<ExpenseHistory>();
        }

        public int ExId { get; set; }
        public string UrDegree { get; set; } = null!;

        public virtual ICollection<ExpenseFormHistory> ExpenseFormHistories { get; set; }
        public virtual ICollection<ExpenseForm> ExpenseForms { get; set; }
        public virtual ICollection<ExpenseHistory> ExpenseHistories { get; set; }
    }
}
