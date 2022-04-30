using Microsoft.AspNetCore.Mvc;

namespace NotesWeb.Controllers
{
    public class MemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
