using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinia;

namespace Aerolinia
{
    public class Colleccion : List<RegistroPasaje>
    {
        
       public Colleccion()
       {

       }
       public int sumar()
       {
           return this.Sum(x => x.Total);
       }
       public int tipo(string tipoo)
       {
           return this.Count(x => x.Tipo.ToString()== tipoo);
       }
       public int ValorMayor()
       {
           return this.Max(x => x.Total);
       }
       
    }
}
