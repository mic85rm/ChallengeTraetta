using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{
  [Table("Compagnia")]
  public class Compagnia
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string NomeCompagnia { get; set; }

    //public virtual ICollection<Indirizzo> Indirizzi { get; set; }

    //public virtual ICollection<MezzoDiContatto> MezziDiContatto { get; set; }
    

    //public virtual ICollection<Prodotto> Prodotti { get; set; }
  }
}
