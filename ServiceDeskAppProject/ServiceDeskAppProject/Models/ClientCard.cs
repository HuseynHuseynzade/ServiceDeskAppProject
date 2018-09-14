using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDeskAppProject.Models
{
    [Table(name: "Cards")]
    public class ClientCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime AddedDate { get; set; }
        public AppUser AddedBy { get; set; }
        public int AddedById { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal Balance { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public CardStatus CardStatus { get; set; }
    }
}
