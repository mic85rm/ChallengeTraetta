using System;

namespace ChallengeTraetta
{
  using ChallengeTraetta.Context;
  using ChallengeTraetta.Models;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;

  public static class DatiIniziali 
  {
    public static void Seed(this CompanyContext context)
    {

      if (!context.Compagnie.Any())
      {
        var compagnie = new List<Compagnia>
            {
            new Compagnia { NomeCompagnia="Michele"},
            new Compagnia{ NomeCompagnia="Giovanni"},
            };

        compagnie.ForEach(s => context.Compagnie.Add(s));
        context.SaveChanges();
      }

      if (!context.Indirizzi.Any())
      {
        var indirizzi = new List<Indirizzo>
      {
       new Indirizzo{ Descrizione="SEDE LEGALE", Via="RUGGIERO BONGHI", NCivico="2", CompagniaID=1},
       new Indirizzo{ Descrizione="SEDE OPERATIVA", Via="DELLO STATUTO", NCivico="6",CompagniaID=1},
       new Indirizzo{ Descrizione="SEDE LEGALE", Via="MERULANA", NCivico="120", CompagniaID=2}
      };
      indirizzi.ForEach(s => context.Indirizzi.Add(s));
      context.SaveChanges();
      }

      if (!context.TipiContatto.Any())
        {
          var tipicontatti = new List<TipoContatto>
      {
       
       new TipoContatto{ Descrizione="Cellulare"},
      new TipoContatto{ Descrizione="Telefono"},
      new TipoContatto{  Descrizione="Email"},

      };
      tipicontatti.ForEach(s => context.TipiContatto.Add(s));
      context.SaveChanges();
      }


      if (!context.MezziDiContatto.Any())
          {
            var mezziDiContatto = new List<MezzoDiContatto>
      {
       new MezzoDiContatto{  TipoContattoID=1, IndirizzoID=1, Valore="mictrt85@gmail.com" },
      new MezzoDiContatto{ TipoContattoID=2, IndirizzoID=1, Valore="060606" },
      new MezzoDiContatto{ TipoContattoID=3, IndirizzoID=1, Valore="3383833838" },
      new MezzoDiContatto{  TipoContattoID=1, IndirizzoID=2, Valore="aaa@gmail.com" },
      new MezzoDiContatto{ TipoContattoID=2, IndirizzoID=2, Valore="020202" },
      new MezzoDiContatto{ TipoContattoID=3, IndirizzoID=2, Valore="34932444" },
      new MezzoDiContatto{  TipoContattoID=1,IndirizzoID=3, Valore="bla@ciao.it" },
      new MezzoDiContatto{ TipoContattoID=3, IndirizzoID=3, Valore="3927180" },
      };
      mezziDiContatto.ForEach(s => context.MezziDiContatto.Add(s));
      context.SaveChanges();
      }



      if (!context.CategorieMerceologiche.Any())
            {
              var categorieMerceologica = new List<CategoriaMerceologica>
      {
      new CategoriaMerceologica{ NomeCategoria="casalinghi" },
      new CategoriaMerceologica{ NomeCategoria="igienepersonale" },
      new CategoriaMerceologica{ NomeCategoria="pc" },
      new CategoriaMerceologica{ NomeCategoria="consumabili" }
      };
      categorieMerceologica.ForEach(s => context.CategorieMerceologiche.Add(s));
      context.SaveChanges();
      }
      if (!context.Prodotti.Any())
              {
                var prodotti = new List<Prodotto>
      {
      new Prodotto{ CategoriaMerceologicaId=3, NomeProdotto="Notebook Acer", QuantitaProdotto=24, CompagniaID=1 },
      new Prodotto{ CategoriaMerceologicaId=4, NomeProdotto="cartuccia stampante epson", QuantitaProdotto=12, CompagniaID=1 },
      new Prodotto{ CategoriaMerceologicaId=2, NomeProdotto="deodorante uomo", QuantitaProdotto=120, CompagniaID=1 },
      new Prodotto{ CategoriaMerceologicaId=3, NomeProdotto="Notebook HP", QuantitaProdotto=2, CompagniaID=1 },
      new Prodotto{ CategoriaMerceologicaId=1, NomeProdotto="scopa", QuantitaProdotto=12220, CompagniaID=2 },
      new Prodotto{ CategoriaMerceologicaId=1, NomeProdotto="paletta", QuantitaProdotto=20, CompagniaID=2 },
      new Prodotto{ CategoriaMerceologicaId=1, NomeProdotto="secchio", QuantitaProdotto=0, CompagniaID=2 }
      };
      prodotti.ForEach(s => context.Prodotti.Add(s));
      context.SaveChanges();
      }

    }
  }

}
