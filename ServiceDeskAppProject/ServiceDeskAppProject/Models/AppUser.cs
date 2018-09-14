using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDeskAppProject.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }

        public AppUser()
        {
            Incidents = new HashSet<Incident>();
        }
    }
}
