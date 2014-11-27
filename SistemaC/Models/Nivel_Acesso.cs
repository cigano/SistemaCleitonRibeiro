using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaC.Models
{
    [Table("NiveisAcessos")]
    public class NivelAcesso
    {
        [Key]
        public int NivelAcessoId { get; set; }
        public String Nivel { get; set; }

        public virtual ICollection<Acesso> Acessos { get; set; }
    }
}