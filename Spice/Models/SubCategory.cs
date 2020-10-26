using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "SubCategory name")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Category")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
    }
}
