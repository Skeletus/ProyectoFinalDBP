using Microsoft.AspNetCore.Mvc;

namespace Web_D1M.Controllers
{
    public class AlumnoController : Controller
    {
        //bdcolegioContext context = new bdcolegioContext() de visual azul xd ;
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


        /*ELIMINAR*/
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

        //EDITAR
        [Route("alumno/Edit/{Codigo}")]
        public IActionResult Edit(string Codigo)
        {
            var objAlu = (from Talu in context.Alumnos
                          where Talu.IdAlumno == Codigo
                          select Talu).Single();

            //arreglo hash
            ViewData["id"] = objAlu.IdAlumno;
            ViewData["ape"] = objAlu.AluPaterno;
            ViewData["mat"] = objAlu.AluMaterno;
            ViewData["nom"] = objAlu.AluNombres;
            ViewData["sex"] = objAlu.AluSexo;

            return View();

        }

        public IActionResult EditAlumno(Alumno objNew)
        {
            if (ModelState.IsValid)
            {

                var ObjOld = (from Talu in context.Alumnos
                              where Talu.IdAlumno == objNew.IdAlumno
                              select Talu).Single();

                ObjOld.AluPaterno = objNew.AluPaterno;
                ObjOld.AluMaterno = objNew.AluMaterno;
                ObjOld.AluNombres = objNew.AluNombres;
                ObjOld.AluSexo = objNew.AluSexo;

                context.SaveChanges(); //manda a la base de datos
                return RedirectToAction("Index");
            }

            else
            {
                return View("Edit");
            }
        }
}
