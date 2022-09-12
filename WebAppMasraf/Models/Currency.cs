using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class Currency
    {
        public Currency()
        {
            ExpenseFormHistories = new HashSet<ExpenseFormHistory>();
            ExpenseForms = new HashSet<ExpenseForm>();
        }

        public int CId { get; set; }
        public string UrCode { get; set; } = null!;

        public virtual ICollection<ExpenseFormHistory> ExpenseFormHistories { get; set; }
        public virtual ICollection<ExpenseForm> ExpenseForms { get; set; }
    }
}
