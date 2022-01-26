using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NyamNyam.Models
{
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<IngredientRecipe> IngredientRecipes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Dishes)
                .WithRequired(e => e.Category1)
                .HasForeignKey(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dish>()
                .HasMany(e => e.Processes)
                .WithMany(e => e.Dishes)
                .Map(m => m.ToTable("DishAndProcess").MapLeftKey("DishID").MapRightKey("ProcessID"));

            modelBuilder.Entity<IngredientRecipe>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IngredientRecipe>()
                .HasMany(e => e.Processes)
                .WithMany(e => e.IngredientRecipes)
                .Map(m => m.ToTable("IngredAndProcess").MapLeftKey("IngredientRID").MapRightKey("ProcessID"));

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.IngredientRecipes)
                .WithRequired(e => e.Ingredient)
                .HasForeignKey(e => e.IngredientName)
                .WillCascadeOnDelete(false);
        }
    }
}
