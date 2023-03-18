using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        [HttpGet]
        public ActionResult GetAll()
        {
            EmpleadoService.EmpleadoClient empleadoClient = new EmpleadoService.EmpleadoClient();//WCF
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();
            //ML.Result result = BL.Empleado.GetAllEF(empleado);//EF
            ML.Result result = empleadoClient.GetAll(empleado);

            if (result.Correct)
            {
                empleado.Empleados = result.Objects;
                return View(empleado);
            }
            else
            {
                return View(empleado);
            }
        }

        [HttpPost]
        public ActionResult GetAll(ML.Empleado empleado)
        {
            EmpleadoService.EmpleadoClient empleadoClient = new EmpleadoService.EmpleadoClient();//WCF
            ML.Result result = empleadoClient.GetAll(empleado);//WCF
            //ML.Result result = BL.Empleado.GetAllEF(empleado);//EF

            if (result.Correct)
            {
                empleado.Empleados = result.Objects;
                return View(empleado);
            }
            else
            {
                return View(empleado);
            }
        }

        [HttpGet]
        //Formulario
        public ActionResult Form(string NumeroEmpleado)
        {
            ML.Result resultEmpresa = BL.Empresa.GetAllEF();

            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();

            if (resultEmpresa.Correct)
            {
                empleado.Empresa.Empresas = resultEmpresa.Objects;
            }
            if (NumeroEmpleado == null)
            {
                //Add Formulario vacio
                return View(empleado);
            }
            else
            {
                //GetById
                EmpleadoService.EmpleadoClient empleadoClient = new EmpleadoService.EmpleadoClient();//WCF
                ML.Result result = empleadoClient.GetById(NumeroEmpleado);
                //ML.Result result = BL.Empleado.GetByIdEF(NumeroEmpleado);

                if (result.Correct)
                {
                    empleado = (ML.Empleado)result.Object;
                    empleado.Empresa.Empresas = resultEmpresa.Objects;
                    return View(empleado);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar la informacion";
                    return View("Modal");
                }
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Empleado empleado)
        {
            //Convirtiendo imagen a byte 
            HttpPostedFileBase file = Request.Files["fuImage"];

            if (file != null)
            {
                byte[] imagen = ConvertToBytes(file);
                empleado.Foto = Convert.ToBase64String(imagen);
            }

            ML.Result result = new ML.Result();
            EmpleadoService.EmpleadoClient empleadoClient = new EmpleadoService.EmpleadoClient();//WCF

            if (empleado.NumeroEmpleado == "")//Tenia ==0
            {
                //Add
                //result = BL.Empleado.AddEF(empleado);
                result = empleadoClient.Add(empleado);//WCF

                if (result.Correct)
                {
                    ViewBag.Message = "Se completo el registro satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al insertar el registro";
                }
                return View("Modal");
            }
            else
            {
                //Update
                //result = BL.Empleado.UpdateEF(empleado);
                result = empleadoClient.Update(empleado);//WCF
                if (result.Correct)
                {
                    ViewBag.Message = "Se actualizo el registro satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al actualizar el registro";
                }
                return View("Modal");
            }
        }

        [HttpGet]
        public ActionResult Delete(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();
            EmpleadoService.EmpleadoClient empleadoClient = new EmpleadoService.EmpleadoClient();//WCF

            //result = BL.Empleado.DeleteEF(empleado);
            result = empleadoClient.Delete(empleado);

            if (result.Correct)
            {
                ViewBag.Message = "Se elimino el registro satisfactoriamente";
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al eliminar el registro";
            }
            return View("Modal");
        }

        public byte[] ConvertToBytes(HttpPostedFileBase Foto)
        {
            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            data = reader.ReadBytes((int)Foto.ContentLength);

            return data;
        }
    }
}