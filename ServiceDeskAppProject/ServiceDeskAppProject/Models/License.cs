using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDeskAppProject.Models
{
    public class License
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime AddedDate { get; set; }
        public Software Software { get; set; }
        public int SoftwareId { get; set; }
        public int KeyCount { get; set; }

    }
}
