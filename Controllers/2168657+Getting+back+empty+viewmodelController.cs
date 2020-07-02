using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    public class _2168657_Getting_back_empty_viewmodelController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductInShopsCheckboxViewModel vm = new ProductInShopsCheckboxViewModel
            {
                ShopName = "Test shop"
            };

            var random = new Random();
            for (int i =0; i < 20; i++)
            {
                vm.Checkboxes!.Add(new CheckboxViewModel
                {
                    ProductName = $"Product {random.Next()}",
                    Barcode = random.Next(),
                    ProductId = Guid.NewGuid()
                });
            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AssortmentSave(Guid id, ProductInShopsCheckboxViewModel vm)
        {
            return View();
        }
    }
}
