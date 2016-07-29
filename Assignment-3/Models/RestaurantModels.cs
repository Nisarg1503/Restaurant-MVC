namespace Assignment_3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantModels : DbContext
    {
        public RestaurantModels()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<ButterMilk> ButterMilks { get; set; }
        public virtual DbSet<Chutney> Chutneys { get; set; }
        public virtual DbSet<FullDish> FullDishes { get; set; }
        public virtual DbSet<IceCream> IceCreams { get; set; }
        public virtual DbSet<Lassi> Lassis { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MiniDish> MiniDishes { get; set; }
        public virtual DbSet<Pickle> Pickles { get; set; }
        public virtual DbSet<RiceKheer> RiceKheers { get; set; }
        public virtual DbSet<Sambharo> Sambharoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ButterMilk>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<ButterMilk>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<ButterMilk>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Chutney>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Chutney>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<Chutney>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<FullDish>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<FullDish>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<FullDish>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<IceCream>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<IceCream>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<IceCream>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Lassi>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Lassi>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<Lassi>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Menu>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ShortDecs)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MiniDish>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<MiniDish>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<MiniDish>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Pickle>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Pickle>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<Pickle>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RiceKheer>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<RiceKheer>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<RiceKheer>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Sambharo>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Sambharo>()
                .Property(e => e.DetailedDecs)
                .IsUnicode(false);

            modelBuilder.Entity<Sambharo>()
                .Property(e => e.Rate)
                .HasPrecision(5, 2);
        }
    }
}
