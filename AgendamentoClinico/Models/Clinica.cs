using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_CLINICA")]
    public class Clinica
    {
        [Key, Column("CLI_IN_CODIGO", Order = 1)]
        public int Codigo { get; set; }

        [Key, Column("CLI_ST_CNPJ", Order = 2)]
        [Display(Name = "CNPJ")]
        public int Cnpj { get; set; }

        [Column("CLI_ST_NOME")]
        [Display(Name = "Nome")]
        public int Nome { get; set; }

        [Column("CLI_ST_TELEFONE")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Column("CLI_ST_ENDERECO")]
        [Display(Name = "Endereço")]
        public int Endereco { get; set; }
    }
}