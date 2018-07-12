using SCV.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

/// <summary>
/// Contexto que representa o banco de dados bd_scv
/// </summary>
namespace SCV.DAL
{
    public class Context: DbContext
    {
        public Context() : base("bd_scv") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var conventions = new List<PluralizingTableNameConvention>().ToArray();
            modelBuilder.Conventions.Remove(conventions);
        }

        public virtual DbSet<ClienteDTO> Clientes { get; set; }
    }
}
