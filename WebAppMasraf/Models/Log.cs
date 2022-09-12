using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class Log
    {
        public int LId { get; set; }
        public string? Exception { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? TransactionDetail { get; set; }
        public int? UUserId { get; set; }

        public virtual User? UUser { get; set; }
    }
}
