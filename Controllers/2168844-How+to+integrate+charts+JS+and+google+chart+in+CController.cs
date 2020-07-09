using Microsoft.AspNetCore.Mvc;

namespace mvcsamples.Controllers
{
    
    public class _2168844_How_to_integrate_charts_JS_and_google_chart_in_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       // [HttpPost]
        // public UserPagingViewModel GetPlotData()
        // {
        //     UserPagingViewModel model = new UserPagingViewModel();
        //     model.ItemCount = 500;
        //     model.CurrentPage = page;
        //     model.TotalPages = model.ItemCount / rows;

        //     var users = new List<UserViewModel>();
        //     for (int i = 0; i < rows; i++)
        //     {
        //         users.Add(GetRandomData.GetRandomDataObject<UserViewModel>());
        //     }
        //     model.Users = users;
        //     return model;
        // }
        // GetRandomData.GetRandomDataObject<UserViewModel>()
    }
}