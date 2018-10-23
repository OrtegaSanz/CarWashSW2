using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GenerarOrdenCompraController : Controller
    {
        // GET: GenerarOrdenCompra
        public ActionResult GenerarOrdenCompra()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GenerarOrdenCompra(PROVEEDOR proveedor)
        {
            var facade = new Facade();
            int ruc = int.Parse(Request["txtProveedor"]);
            var datos = facade.BuscarProveedor(ruc);
            ViewData["RazonSocial"] = datos.RAZON_SOCIAL;
            ViewData["Direccion"] = datos.DIRECCION;
            ViewData["Ruc"] = datos.RUC;
            ViewData["Telefono"] = datos.TELEFONO;
            if (Request["txtDireccion"] != null, Request[""])
            {

            }
            return View();
        }
    }
}