﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoClinico.Models
{
    [Table("AGC_SITUACAO")]
    public class Situacao
    {
        [Key]
        [Column("SIT_IN_CODIGO")]
        public int Codigo { get; set; }

        [Column("SIT_ST_DESCRICAO")]
        public string Descricao { get; set; }
    }
}