namespace KeyPass2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=onlineDB")
        {
        }

        public virtual DbSet<password> password { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<password>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<password>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<password>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<password>()
                .Property(e => e.password_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
