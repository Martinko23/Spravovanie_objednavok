using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category
    {
        public int ID { get; set; }
        [DisplayName("Meno")]
        public string Name { get; set; }
        
    }
}
