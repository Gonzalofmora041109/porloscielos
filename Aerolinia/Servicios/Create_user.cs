using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinia.Modelo;
namespace Aerolinia.Servicios
{
   public  class Create_user
    {
        private Modelo1 db = new Modelo1();

        public void Agregar(string nombre,string apelldido) {

            db.Users.Add(new User {Nombre=nombre,Apellido=apelldido });
            db.SaveChanges();

        }
    }
}
