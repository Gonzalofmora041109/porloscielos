namespace Aerolinia.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Modelo1 : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Modelo1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Aerolinia.Modelo.Modelo1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Modelo1'  en el archivo de configuración de la aplicación.
        public Modelo1()
            : base("name=Modelo1")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }

}