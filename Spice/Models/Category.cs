using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category name")]
        public string Name { get; set; }


        //public string[] Title()
        //{
            
        //    string[] title;
        //    if (Id.ToString() != "")
        //    {
        //        title = new string[] { "Update Category", "Update" };
        //        return (title);
        //    }
        //    else
        //    {
        //        title = new string[] { "New Category", "Create" };
        //        return (title);
        //    }
        //}


    }




}
