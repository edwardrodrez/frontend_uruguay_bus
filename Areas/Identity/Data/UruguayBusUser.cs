using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Models.Entities;

namespace UruguayBus.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UruguayBusUser class
    public class UruguayBusUser : IdentityUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
        public string fechaLibreta { get; set; }
        public string Stamp { get; set; }

        public virtual ICollection<string> UserRoles { get; set; }
        public string FullName
        {
            get
            {
                return nombre + " " + apellido;
            }
        }
    }
}
