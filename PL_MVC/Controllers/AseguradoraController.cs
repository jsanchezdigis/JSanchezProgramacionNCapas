using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAll()
        {
            AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient();//WCF
            ML.Result result = aseguradoraClient.GetAll();//WCF
            //ML.Result result = BL.Aseguradora.GetAllEF();//EF
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
                return View(aseguradora);
            }
            else
            {
                return View(aseguradora);
            }
        }

        [HttpGet]
        //Formulario
        public ActionResult Form(int? IdAseguradora)
        {
            AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient();//WCF
            ML.Usuario usuario = new ML.Usuario();
            ML.Result resultUsuario = BL.Usuario.GetAllEF(usuario);
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();

            if (resultUsuario.Correct)
            {
                aseguradora.Usuario.Usuarios = resultUsuario.Objects;
            }
            if (IdAseguradora == null)
            {
                //Add
                return View(aseguradora);
            }
            else
            {
                //GetById
                //ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);
                ML.Result result = aseguradoraClient.GetById(IdAseguradora.Value);//WCF

                if (result.Correct)
                {
                    aseguradora = (ML.Aseguradora)result.Object;
                    aseguradora.Usuario.Usuarios = resultUsuario.Objects;
                    return View(aseguradora);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar la informacion";
                    return View("Modal");
                }
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient();//WCF

            if (aseguradora.IdAseguradora == 0)
            {
                //Add
                //result = BL.Aseguradora.AddEF(aseguradora);
                result = aseguradoraClient.Add(aseguradora);

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
                //result = BL.Aseguradora.UpdateEF(aseguradora);
                result = aseguradoraClient.Update(aseguradora);

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
        public ActionResult Delete(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient();//WCF

            //result = BL.Aseguradora.DeleteEF(aseguradora);
            result = aseguradoraClient.Delete(aseguradora);

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
    }
}