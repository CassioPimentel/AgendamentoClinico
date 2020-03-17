using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_AGENDAMENTO")]
    public class Agendamento
    {
        [Key]
        [Column("AGD_IN_CODIGO")]
        public int Codigo { get; set; }

        [ForeignKey(nameof(Paciente)), Column("AGD_IN_CODIGO_PACIENTE")]
        public int CodigoPaciente { get; set; }

        [ForeignKey(nameof(Clinica)), Column("AGD_IN_CODIGO_CLINICA")]
        public int CodigoClinica { get; set; }

        [ForeignKey(nameof(Situacao)), Column("AGD_IN_CODIGO_SITUACAO")]
        public int CodigoSituacao { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Clinica Clinica { get; set; }
        public virtual Situacao Situacao { get; set; }
    }
}