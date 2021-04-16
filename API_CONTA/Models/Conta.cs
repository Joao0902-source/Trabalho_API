using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_CONTA.Models
{
    [Table("Contas")]
    public class Conta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int Id { get; set; }
        [Required]

        [MaxLength(30, ErrorMessage = "O campo nome do credor deve possuir apenas 30 caracteres!")]
        public string Nome_credor { get; set; }
        [Required(ErrorMessage = "Informa a data do vencimento!")]
        [Display(Name = "Data do vencimento")]
        [DataType(DataType.Date)]


        public DateTime Data_vencimento { get; set; }



        [Required]
        [MaxLength(4, ErrorMessage = "O valor do pagamento deve possuir apenas 4 caracteres!")]
        public string Val_pagar { get; set; }
        [Required(ErrorMessage = "Informe a data do pagamento!")]
        [Display(Name = "Data do pagamento")]
        [DataType(DataType.Date)]

        public DateTime Data_pagamento { get; set; }
    }
}
