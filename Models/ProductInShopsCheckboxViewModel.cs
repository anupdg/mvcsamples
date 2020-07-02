using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
    public class ProductInShopsCheckboxViewModel
    {
        public string ShopName { get; set; } = default!;

        public List<CheckboxViewModel>? Checkboxes { get; set; } = new List<CheckboxViewModel>();
    }
    public class CheckboxViewModel
    {
        public bool IsSelected { get; set; } = true;

        public string ProductName { get; set; } = default!;

        public long Barcode { get; set; }

        public Guid ProductId { get; set; }

    }
}
