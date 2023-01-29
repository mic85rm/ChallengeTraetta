using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{
  [Table("CategoriaMerceologica")]
  public class CategoriaMerceologica
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string NomeCategoria { get; set; }

    
  }
}
