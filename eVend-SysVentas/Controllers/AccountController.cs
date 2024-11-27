using Microsoft.AspNetCore.Mvc;

namespace eVend_SysVentas.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RegistrarUsuario() {
            return View();
        }

        public IActionResult VerificarUsuario() {
            return View();
        }

        public IActionResult PagoUsuario() {
            return View();
        }

        public IActionResult CompletoUsuario() {
            return View();
        }
    }
}
