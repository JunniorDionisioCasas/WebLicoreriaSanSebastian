using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class _dbContext:DbContext
    {
        #region configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            //    configurationBuild = configurationBuild.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            // Leemos el archivo de configuración.
            string conneccion = configurationFile.GetConnectionString("CRUZDEMAYO");
            optionsBuilder.UseSqlServer(connectionString: conneccion);
        }
        #endregion

        public DbSet<CategoriaModel> Categoria { get; set; }
        public DbSet<PersonaModel> Persona { get; set; }
        public DbSet<CargoModel> Cargo { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<DetalleEntradaModel> DetalleEntrada { get; set; }
        public DbSet<DetalleSalidaModel> DetalleSalida { get; set; }
        public DbSet<LaboratorioModel> Laboratorio { get; set; }
        public DbSet<MedicamentoModel> Medicamento { get; set; }
        public DbSet<PresentacionModel> Presentacion { get; set; }
        public DbSet<ProveedorModel> Proveedor { get; set; }
        public DbSet<SalidaModel> Salida { get; set; }
        public DbSet<SucursalModel> Sucursal { get; set; }
        public DbSet<EntradaModel> Entradas { get; set; }


    }
}
