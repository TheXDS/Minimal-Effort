using System.Data.Entity;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace EffortTesting
{
    public static class Program
    {
        private static void Main()
        {
            using (var context = new MiTestContext())
            {
                context.Contactos.Add(new Contacto
                {
                    Nombre = "Pedro Perez",
                    Correo = "pedro@test.com"
                });
                context.SaveChanges();
            }
        }
    }

    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }

    public class MiTestContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
    }
}