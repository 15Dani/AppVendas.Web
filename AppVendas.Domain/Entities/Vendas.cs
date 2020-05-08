using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Entities
{
   public class Vendas : EntityBase
    {
        public string Nm_cliente { get; set; }
        public DateTime Dt_venda { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public double Valor { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Boolean Sn_ativo { get; set; }
    }
}

