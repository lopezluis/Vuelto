using Microsoft.EntityFrameworkCore;

namespace Vuelto.Persistencia
{
    public class ContextoDatos : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConexionBaseDatos"));
            base.OnConfiguring(optionsBuilder);
        }

#pragma warning disable CS8618
        public Microsoft.EntityFrameworkCore.DbSet<Vuelto.Modelo.Transaccion> Transaccion { get; set; }
#pragma warning restore CS8618
    }
}
