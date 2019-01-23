using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Identity;

namespace WebApplication1.Models
{
    public class Order
    {
        public int ID { get; set; }
        [DisplayName("Vytvorená")]
        public DateTime Created { get; set; }
        [DisplayName("Odkaz")]
        [Required]
        public string Link { get; set; }
        [DisplayName("Cena")]
        public float Price { get; set; }
        [DisplayName("Stav")]
        public string Status { get; set; }
        [DisplayName("Zaplatene")]
        public bool Paid { get; set; }
        [DisplayName("Používateľ")]
        public ApplicationUser User { get; set; }
        [DisplayName("Kategória")]
        public Category Category { get; set; }
    }
}
