using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_CLINICA")]
    public class Clinica
    {
        [Key]
        [Column("CLI_IN_CODIGO")]
        public int Codigo { get; set; }

        [Column("CLI_ST_CNPJ")]
        public int Cnpj { get; set; }

        [Column("CLI_ST_NOME")]
        public int Nome { get; set; }

        [Column("CLI_ST_TELEFONE")]
        public int Telefone { get; set; }

        [Column("CLI_ST_ENDERECO")]
        public int Endereco { get; set; }
    }
}