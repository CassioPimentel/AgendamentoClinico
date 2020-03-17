using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_CONVENIO_PACIENTE")]
    public class ConvenioPaciente
    {
        [Key]
        [Column("CVP_IN_CODIGO")]
        public int Codigo { get; set; }

        [Column("CVP_IN_NUM_CONV_PACIENTE")]
        public string NumeroConvenioPaciente { get; set; }

        [ForeignKey(nameof(Convenio)), Column("CVP_IN_CODIGO_CONVENIO")]
        public string CodigoConvenio { get; set; }

        public virtual Convenio Convenio { get; set; }
    }
}