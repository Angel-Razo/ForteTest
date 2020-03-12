using System;
using System.Collections.Generic;
using System.Text;

namespace ForteTestApi.Models.Helpers
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int MyProperty { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public int Domicilio { get; set; }
        public decimal LimiteCredito { get; set; }
        public Byte EstatusClienteId { get; set; }
        public EstatusCliente EstatusCliente { get; set; }
    }

}
