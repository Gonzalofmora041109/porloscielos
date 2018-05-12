using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.Modelo;

namespace Aerolinia
{
   public  class RegistrodeUsuario
    {
        private string  nombre;
        private string apellido;
        private Servicios.ServicioUsuario ServicioUsuario=new Servicios.ServicioUsuario() ;
        public void RegistrarUsuario(String nombre,String apeliido) {
            try
            {
                this.nombre = nombre;
                this.apellido = apeliido;
                ServicioUsuario.crear(new Usuario {Nombre=this.nombre,Apellido=this.apellido });
                
            }
            catch (Exception e )
            {
                e.GetBaseException();

                

            }
           

        }
    }
}
