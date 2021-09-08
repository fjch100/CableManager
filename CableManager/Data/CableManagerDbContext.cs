using CableManager.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CableManagerDbContext : DbContext
    {
        public CableManagerDbContext()
          : base()
        {

        }


        public virtual DbSet<Carrera> Carreras { get; set; }

        public virtual DbSet<Cable> Cables { get; set; }
    }
}
