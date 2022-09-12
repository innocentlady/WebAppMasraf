using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class ExpenseFormHistory
    {
        public ExpenseFormHistory()
        {
            ExpenseHistories = new HashSet<ExpenseHistory>();
        }

        public int EfhId { get; set; }
        public int? UExpenseFormId { get; set; }
        public int? UExpenseFormstatusId { get; set; }
        public int? UUserId { get; set; }
        public string? ExpenseFormDescription { get; set; }
        public string? ExpenseFormReject { get; set; }
        public int? UExpenseCurrencyId { get; set; }
        public string? Descriptions { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? IsExpenseFormdeleted { get; set; }

        public virtual Currency? UExpenseCurrency { get; set; }
        public virtual ExpenseForm? UExpenseForm { get; set; }
        public virtual ExpenseStatus? UExpenseFormstatus { get; set; }
        public virtual User? UUser { get; set; }
        public virtual ICollection<ExpenseHistory> ExpenseHistories { get; set; }
    }
}
