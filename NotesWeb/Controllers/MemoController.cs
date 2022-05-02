using Microsoft.AspNetCore.Mvc;
using NotesWeb.Data;
using NotesWeb.Models;
namespace NotesWeb.Controllers
{
    public class MemoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemoController(ApplicationDbContext db)
        {
            _db = db;
        }
        // Enumberable for listing memo content
        public IActionResult Index()
        {
            IEnumerable<MemoModel> objMemoList = _db.Memos;
            return View(objMemoList);
        }

        // Open page for creating memo
        public IActionResult Create()
        {
            return View();
        }
    }
}
