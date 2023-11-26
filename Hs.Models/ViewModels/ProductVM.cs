using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hs.Models.ViewModels
{
    public class ProductVM
    {

        //Create a product property
        public Product Product { get; set; }
        //create an IEnumerable to hold the dropdown

        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }

    }
}