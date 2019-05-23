using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class Role
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
