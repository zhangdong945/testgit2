namespace testgit2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BooksContext : DbContext
    {
        public BooksContext()
            : base("name=BooksContext")
        {
        }

        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<book> books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<news>()
                .Property(e => e.title)
                .IsUnicode(false);
        }
    }
}
