using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    public class _2168647_how_to_show_popup_with_list_returned_by_ajax_result_set_and_how_to_select_item_and_return_it_back_to_parent_htmlController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public List<UserViewModel> GetUsers() {
            var users = new List<UserViewModel>();
            for (int i = 0; i < 20; i++)
            {
                users.Add(GetRandomData.GetRandomDataObject<UserViewModel>());
            }
            return users;
        }
    }
}
