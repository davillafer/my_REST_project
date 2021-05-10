using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS.Proyecto.Mapa.WebAPI.Model;

namespace WS.Proyecto.Mapa.WebAPI.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlite("Data Source=database.db"); 
        }
        public DbSet<Petition> Petitions { get; set; }
    }
}
