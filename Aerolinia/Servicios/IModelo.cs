using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolinia.Servicios
{
   public interface IModelo
    {

        string buscar(int id);
        void eliminar();
    }
}
