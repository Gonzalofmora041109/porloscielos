namespace datos
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Modelo;
    public class Datos : DbContext
    {
       
        public Datos()
            : base("name=datos")
        {
        }

      
        public virtual DbSet<Usuario> Usuario { get; set; }
    }

   
}