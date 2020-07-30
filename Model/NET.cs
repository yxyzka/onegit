namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NET : DbContext
    {
        public NET()
            : base("name=NET")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Goods_Type> Goods_Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
