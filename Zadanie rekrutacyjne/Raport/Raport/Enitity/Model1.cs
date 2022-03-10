using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Raport.Enitity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base(UserSetting.ConnString)
        {
        }

        public virtual DbSet<Raport> Raports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raport>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<Raport>()
                .Property(e => e.Użytkownik)
                .IsUnicode(false);

            modelBuilder.Entity<Raport>()
                .Property(e => e.Lokal)
                .IsUnicode(false);
        }
    }
}
