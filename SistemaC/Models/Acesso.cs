using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaC.Models
{
    [Table("Acessos")]
    public class Acesso
    {
        [Key]
        public int AcessoId { get; set; }
        public int NivelAcessoId { get; set; }

        [Required]
        public String Usuario { get; set; }
        [DataType(DataType.Password)]
        public String Senha { get; set; }

        public virtual NivelAcesso NivelAcesso { get; set; }
    }
}