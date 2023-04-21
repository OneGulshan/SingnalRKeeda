using Microsoft.AspNetCore.Mvc;

namespace SingnalRKeeda.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
