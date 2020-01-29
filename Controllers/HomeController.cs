using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = Article.GetArticles("9LWx79tU9QPjIubaRLscjuGoFyngxkKx");
            return View(allArticles);
        }
    }
}
