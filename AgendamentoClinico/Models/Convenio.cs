using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_CONVENIO")]
    public class Convenio
    {
        [Key]
        [Column("COV_IN_CODIGO")]
        public int Codigo { get; set; }

        [Column("COV_ST_DESCRICAO")]
        public string Descricao { get; set; }
    }
}