using Microsoft.AspNetCore.Mvc;

namespace Web_D1M.Controllers
{
    public class AlumnoController : Controller
    {
        //bdcolegioContext context = new bdcolegioContext();
        private readonly bdcolegioContext context;
        public AlumnoController(bdcolegioContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var list = context.Alumnos;
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateAlumno(Alumno objAlu)
        {
            if(ModelState.IsValid)
            {
                context.Alumnos.Add(objAlu);
                context.SaveChanges();

                return RedirectToAction("Index"); 
            }
            else
            {
                return View("Create");
            }
        }
        [Route("alumno/Delete/{Codigo}")]
        public IActionResult Delete(string Codigo)
        {
            /*LINQ * lambda*/
            var objAlu = (from Talu in context.Alumnos
                          where Talu.IdAlumno == Codigo
                          select Talu).Single(); 
            context.Alumnos.Remove(objAlu);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
