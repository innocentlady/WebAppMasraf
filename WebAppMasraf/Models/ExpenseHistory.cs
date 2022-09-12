using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class ExpenseHistory
    {
        public int ExphId { get; set; }
        public int? UExpenseFormId { get; set; }
        public int? UExpenseFormstatusId { get; set; }
        public int? UExpenseId { get; set; }
        public int? UExpenseFormHistoryId { get; set; }
        public int? UUserId { get; set; }
        public string? ExpenseDescription { get; set; }
        public double? ExpenseAmount { get; set; }
        public string? Descriptions { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? IsExpensedeleted { get; set; }

        public virtual Expense? UExpense { get; set; }
        public virtual ExpenseForm? UExpenseForm { get; set; }
        public virtual ExpenseFormHistory? UExpenseFormHistory { get; set; }
        public virtual ExpenseStatus? UExpenseFormstatus { get; set; }
        public virtual User? UUser { get; set; }
    }
}
