using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCSamples.Controllers;
using MVCSamples.Models;

namespace mvcsamples.Controllers
{
    public class _2168660_How_to_load_jQgrid_with_Json_data_coming_from_database_in_ASP_NET_COREController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public UserPagingViewModel GetUsers(int page, int rows, string sidx, string sort)
        {
            UserPagingViewModel model = new UserPagingViewModel();
            model.ItemCount = 500;
            model.CurrentPage = page;
            model.TotalPages = model.ItemCount / rows;

            var users = new List<UserViewModel>();
            for (int i = 0; i < rows; i++)
            {
                users.Add(GetRandomData.GetRandomDataObject<UserViewModel>());
            }
            model.Users = users;
            return model;
        }
    }
}