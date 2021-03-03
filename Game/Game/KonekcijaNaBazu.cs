using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class KonekcijaNaBazu:DbContext
    {
        public KonekcijaNaBazu():base("PutanjaDoBaze")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
    }
}
