using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{
  [Table("MezzoDiContatto")]
  public class MezzoDiContatto
  {
   

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{ get; set; }

    [Required]
    public string Valore { get; set; }

    [Required]
    [ForeignKey("TipoContattoId")]
    public int TipoContattoID{ get; set; }
    public TipoContatto TipoContatto { get; set; }


    [Required]
    [ForeignKey("IndirizzoId")]
    public int IndirizzoID { get; set; }
    public Indirizzo Indirizzo { get; set;}

  }
}
