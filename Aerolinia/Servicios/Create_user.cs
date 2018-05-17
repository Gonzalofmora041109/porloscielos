using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinia.Modelo;
namespace Aerolinia.Servicios
{
   public  class Create_user:IModelo
    {   
        //metodos implementa IModelo//
        private Modelo1 db = new Modelo1();

        public void registrar(string nombre,string apelldido) {

            db.Users.Add(new User {Nombre=nombre,Apellido=apelldido });
            db.SaveChanges();

        }

        public string buscar(int id) {
            var Busqueda = (from i in db.Users where i.id == id select i.Nombre).First();
            return Busqueda;
        }

        public void eliminar() { }



    }
}
