using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDeskAppProject.Models
{
    public class SelledLicense
    {
        public int Id { get; set; }
        public License License { get; set; }
        public int LicenseId { get; set; }
        public int Count { get; set; }
        public DateTime SelledDate { get; set; }
        public AppUser SelledBy { get; set; }
        public string SelledById { get; set; }

    }
}
