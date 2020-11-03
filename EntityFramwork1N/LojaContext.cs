using EntityFramwork1N.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1N
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base("Name=DbLojas")
        {
            //Database.SetInitializer<LojaContext>(
            //    new CreateDatabaseIfNotExists<LojaContext>());
            //Database.Initialize(false);
            //Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
            Database.Log = comando => System.Diagnostics.Debug.WriteLine(comando);

        }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Marca> Marcas { get; set; }
    }
}


