using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{

  [Table("Prodotto")]

  public class Prodotto
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string NomeProdotto{ get; set; }

    [Required]
    public int QuantitaProdotto { get; set; }

    [Required]
    [ForeignKey("CategoriaMerceologicaId")]
    public int CategoriaMerceologicaId { get; set; }
    public CategoriaMerceologica CategoriaMerceologica { get; set; }
    [Required]
    [ForeignKey("CompagniaId")]
    public int CompagniaID { get; set; }

  }
}
