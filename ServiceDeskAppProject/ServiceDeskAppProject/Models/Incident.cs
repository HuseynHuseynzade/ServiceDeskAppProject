using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDeskAppProject.Models
{
    public class Incident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public IncidentStatus IncidentStatus { get; set; }
        public string ProblemDescription { get; set; }
        [Required]
        public string TeamviewerId { get; set; }
        public AppUser Operator { get; set; }
        public string OperatorId { get; set; }
        public DateTime? OperatorReactDate { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public string SolveDescription { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
