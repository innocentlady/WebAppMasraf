using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class User
    {
        public User()
        {
            ExpenseFormHistories = new HashSet<ExpenseFormHistory>();
            ExpenseForms = new HashSet<ExpenseForm>();
            ExpenseHistories = new HashSet<ExpenseHistory>();
            Logs = new HashSet<Log>();
        }

        public int UId { get; set; }
        public string? UEmail { get; set; }
        public string? UPasword { get; set; }
        public string UName { get; set; } = null!;
        public string USurname { get; set; } = null!;
        public string? UPhoneNumber { get; set; }
        public DateTime? UDateTime { get; set; }
        public int? UUserRoleId { get; set; }

        public virtual UserRole? UUserRole { get; set; }
        public virtual ICollection<ExpenseFormHistory> ExpenseFormHistories { get; set; }
        public virtual ICollection<ExpenseForm> ExpenseForms { get; set; }
        public virtual ICollection<ExpenseHistory> ExpenseHistories { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
