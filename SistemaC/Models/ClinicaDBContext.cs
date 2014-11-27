using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SistemaC.Models
{
    public class ClinicaDbContext : DbContext 
    {
        //public ClinicaDBContext()
        //{
        //    Database.SetInitializer<ClinicaDBContext>(new CreateDatabaseIfNotExists<ClinicaDBContext>());
        //}
            public DbSet<NivelAcesso> NivelAcessos { get; set; }
            public DbSet<Acesso> Acessos { get; set; }
        
    }
}