using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webApi.Entities;

namespace Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<IngredientsForRecipe> IngredientsForRecipes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=MyDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IngredientsForRecipe>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("IngredientsForRecipe");

            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IngredientCodeNavigation).WithMany(p => p.IngredientsForRecipes)
                .HasForeignKey(d => d.IngredientCode)
                .HasConstraintName("FK_IngredientsForRecipe_Ingredients");

            entity.HasOne(d => d.RecipeCodeNavigation).WithMany(p => p.IngredientsForRecipes)
                .HasForeignKey(d => d.RecipeCode)
                .HasConstraintName("FK_IngredientsForRecipe_Recipe");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Recipe");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Desc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Instructions)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserCode)
                .HasConstraintName("FK_Recipe_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirsName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
