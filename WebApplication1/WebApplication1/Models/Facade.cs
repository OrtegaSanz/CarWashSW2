using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Facade
    {
        public PROVEEDOR BuscarProveedor(int RUC)
        {
            var context = new CARWASHEntities1();
            var datos = context.PROVEEDOR.Find(RUC);
            //context.SaveChanges();
            return datos;
        }
        public MATERIALES BuscarMaterial(int RUC)
        {
            var context = new CARWASHEntities1();
            var datos = context.MATERIALES.Find(RUC);
            //context.SaveChanges();
            return datos;
        }
    }
}