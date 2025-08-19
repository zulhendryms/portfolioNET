
using Microsoft.AspNetCore.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
