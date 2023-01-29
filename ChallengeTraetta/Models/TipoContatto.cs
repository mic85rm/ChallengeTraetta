using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeTraetta.Models
{
  
  

  [Table("TipoContatto")]
public class TipoContatto
{

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }


    public string Descrizione { get; set; }

    

  }
}
