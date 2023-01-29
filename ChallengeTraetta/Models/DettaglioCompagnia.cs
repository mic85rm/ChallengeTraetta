using System.Collections.Generic;

namespace ChallengeTraetta.Models
{
  public class DettaglioCompagnia
  {
    public int Id { get; set; }
    public string NomeCompagnia { get; set; }

    public Indirizzo Indirizzi { get; set; }

    public MezzoDiContatto MezziDiContatto { get; set; }


    public Prodotto Prodotti { get; set; }
  }
}
