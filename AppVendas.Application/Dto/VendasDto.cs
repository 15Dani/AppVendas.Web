using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppVendas.Application.Dto
{
   public class VendasDto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nm_cliente { get; set; }

        [Required(ErrorMessage = "Informe a Data da venda")]
        public DateTime Dt_venda { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe a latitude")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "Informe a longitude")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "Informe a situação da venda")]
        public Boolean Sn_ativo { get; set; }
    }
}
