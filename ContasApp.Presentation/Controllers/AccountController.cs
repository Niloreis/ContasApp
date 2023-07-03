using Microsoft.AspNetCore.Mvc;

namespace ContasApp.Presentation.Controllers
{
    public class AccountController : Controller
    {

        /// <summary>
        /// Metedo para abrir pagina /Account/Login
        /// </summary>
        /// 
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Metedo para abrir pagina /Account/Register
        /// </summary>

        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Metedo para abrir pagina /Account/ForgotPassword
        /// </summary>
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }  
}
