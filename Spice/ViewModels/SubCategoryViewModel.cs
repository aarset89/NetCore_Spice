using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spice.Models;

namespace Spice.ViewModels
{
    public class SubCategoryViewModel
    {
        public SubCategory SubCategory { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public string  Message { get; set; }
    }
}
