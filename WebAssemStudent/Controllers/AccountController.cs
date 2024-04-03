using Microsoft.AspNetCore.Mvc;

namespace WebAssemStudent.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
        
    }
}
