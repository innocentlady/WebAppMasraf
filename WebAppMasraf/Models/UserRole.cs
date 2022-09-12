using System;
using System.Collections.Generic;

namespace WebAppMasraf.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public int UrId { get; set; }
        public string UrDegree { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
