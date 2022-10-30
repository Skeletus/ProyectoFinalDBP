using Microsoft.AspNetCore.Mvc;

namespace Web_D1M.Controllers
{
    public class UsuarioController : Controller
    {
        //bdcolegioContext context = new bdcolegioContext() de visual azul xd ;
        private readonly bdPruebaUserContext context;
        public UsuarioController(bdPruebaUserContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistrarUserPage()
        {
            return View();
        }
        public IActionResult ListaUsuarios()
        {
            var list = context.Users;
            return View(list);
        }
        
        public IActionResult RegistrarUser(User objUser)
        {

            if (ModelState.IsValid)
            {
                context.Users.Add(objUser);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("RegistrarUserPage");
            }

        }

        public IActionResult LogearUsuario(User objUserVerify)
        {
            if (ModelState.IsValid)
            {

                var ObjEncontrado =
                    (from TUsuario in context.Users
                     where TUsuario.NombreUser == objUserVerify.NombreUser &&
                     TUsuario.PasswordUser == objUserVerify.PasswordUser
                     select TUsuario).FirstOrDefault();
                if (ObjEncontrado == null)
                {
                    return RedirectToAction("ListaUsuarios", "Usuario");
                }
                else
                {
                    //Crear la variable de sesion
                    //HttpContext.Session.SetString("sprofesor", JsonConvert.SerializeObject(ObjEncontrado));
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("RegistrarUserPage", "Usuario");
            }
        }

    }
}
