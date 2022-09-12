using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class ExpenseForm
    {
        public ExpenseForm()
        {
            ExpenseFormHistories = new HashSet<ExpenseFormHistory>();
            ExpenseHistories = new HashSet<ExpenseHistory>();
            Expenses = new HashSet<Expense>();
        }

        public int ExfId { get; set; }
        public int? UUserId { get; set; }
        public int? UExpenseStatusId { get; set; }
        public int? UCurrencyId { get; set; }
        public string? Descriptions { get; set; }
        public string RejectReason { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? Isdeleted { get; set; }

        public virtual Currency? UCurrency { get; set; }
        public virtual ExpenseStatus? UExpenseStatus { get; set; }
        public virtual User? UUser { get; set; }
        public virtual ICollection<ExpenseFormHistory> ExpenseFormHistories { get; set; }
        public virtual ICollection<ExpenseHistory> ExpenseHistories { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
