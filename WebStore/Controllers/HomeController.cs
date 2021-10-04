using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();
        
        public IActionResult Cart() => View();

        public IActionResult Checkout() => View();

        public IActionResult Login() => View();

        public IActionResult ContactUs() => View();

        public IActionResult ProductDetails() => View();

        public IActionResult Status(string id)
        {
            return id switch
            {
                "404" => View("NotFound"),
                _ => Content($"Status Code: {id}"),
            };
        }
    }
}
