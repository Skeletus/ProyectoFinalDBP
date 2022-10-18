using Microsoft.AspNetCore.Mvc;

namespace Web_D1M.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistrarUserPage()
        {
            return View();
        }
        /*
        public IActionResult CreateUser(Usuario objUser)
        {
            
            if (ModelState.IsValid)
            {
                objUser.Usuarios.Add(objUser);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("RegistrarUserPage");
            }
            
        }
        */
    }
}
