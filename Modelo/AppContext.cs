using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AppContext : DbContext
    {
        private DbSet<Tarea> Tareas {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=");
            //optionsBuilder.UseSqlite("Data Source=todo.db");
        }
    }
}
