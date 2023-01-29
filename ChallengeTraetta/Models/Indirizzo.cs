using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{
  [Table("Indirizzo")]
  public class Indirizzo
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Descrizione { get; set; }
    [Required]
    public string Via { get; set; }

    public string NCivico { get; set; }
    [Required]
    [ForeignKey("CompagniaId")]
    public int  CompagniaID { get; set; }

    public Compagnia Compagnia { get; set; }
  }
}
