

namespace ChallengeTraetta.Context
{
  using ChallengeTraetta.Models;
using Microsoft.EntityFrameworkCore;
  public class CompanyContext:DbContext
  {
    public CompanyContext(DbContextOptions options)
            : base(options)
    {

    }

    public DbSet<Compagnia> Compagnie { get; set; }
    public DbSet<Prodotto> Prodotti { get; set; }

    public DbSet<CategoriaMerceologica> CategorieMerceologiche { get; set; }
    public DbSet<Indirizzo> Indirizzi { get; set; }
    public DbSet<MezzoDiContatto> MezziDiContatto { get; set; }
    public DbSet<TipoContatto> TipiContatto { get; set; }

   

  }
}
