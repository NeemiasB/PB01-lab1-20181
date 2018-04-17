using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPB01Lab1_NEEMIAS.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="CPF é obrigatorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage ="Email é obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Data Cadastro é obrigatoria")]
        public DateTime DataCadastro { get; set; }
    }
}
