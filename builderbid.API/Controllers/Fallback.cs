using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace builderbid.API.Controllers
{
    public class Fallback : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", 
            "index.html"), "text/HTML");
        }
    }
}