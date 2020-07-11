using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    public class ServerSidePagingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<UserPagingViewModel> GetPagedData(int page, int pageSize)
        {
            UserPagingViewModel model = new UserPagingViewModel();
            model.ItemCount = 500;// Get this count from database query
            model.CurrentPage = page; 
            model.TotalPages = model.ItemCount / pageSize;

            var users = new List<UserViewModel>();
            //Getting random data, get this from database
            for (int i = 0; i < pageSize; i++)
            {
                users.Add(GetRandomData.GetRandomDataObject<UserViewModel>());
            }
            model.Users = users;
            return Json(model); 
        }

        [HttpPost]
        public ActionResult<UserPagingViewModel> GetPagedDataModel([FromBody] PagingModel pagingInfo)
        {
            UserPagingViewModel model = new UserPagingViewModel();
            model.ItemCount = 500;// Get this count from database query
            model.CurrentPage = pagingInfo.Page;
            model.TotalPages = model.ItemCount / pagingInfo.PageSize;

            var users = new List<UserViewModel>();
            //Getting random data, get this from database
            for (int i = 0; i < pagingInfo.PageSize; i++)
            {
                users.Add(GetRandomData.GetRandomDataObject<UserViewModel>());
            }
            model.Users = users;
            return Json(model);
        }
    }
}
