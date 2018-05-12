using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.Modelo;
namespace Aerolinia.Servicios
{
    public  class ServicioUsuario
    {
        private datos.Datos db = new datos.Datos();

        public void crear(Usuario usuario) {

            db.Usuario.Add(usuario);
            db.SaveChanges();

        }
    }
}
