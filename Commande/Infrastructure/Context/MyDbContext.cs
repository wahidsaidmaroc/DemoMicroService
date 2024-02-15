using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Infrastructure.Context;

public  class MyDbContext : DbContext
{
    public MyDbContext()  { }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Produit> Produits { get; set; }
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<CommandeDetail> CommandeDetails { get; set; }
}
