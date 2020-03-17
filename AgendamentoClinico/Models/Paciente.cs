using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_PACIENTE")]
    public class Paciente
    {
        [Key, Column("PAC_IN_CODIGO", Order = 1)]
        public int Codigo { get; set; }

        [Key, Column("PAC_ST_CPF", Order = 2)]
        public string Cpf { get; set; }

        [Column("PAC_ST_NOME_COMPLETO")]
        public string NomeCompleto { get; set; }

        [Column("PAC_ST_TELEFONE")]
        public string Telefone { get; set; }

        [Column("PAC_ST_EMAIL")]
        public string Email { get; set; }

        [ForeignKey(nameof(ConvenioPaciente)), Column("PAC_IN_NUM_CONV_USUARIO")]
        public int CodigoConvenioUsuario { get; set; }

        public ConvenioPaciente ConvenioPaciente { get; set; }
    }
}