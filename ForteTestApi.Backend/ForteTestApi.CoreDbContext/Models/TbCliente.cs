using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbCliente
    {
        public int ClienteId { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public string Domicilio { get; set; }
        public decimal? LimiteCredito { get; set; }
        public bool? EstatusCliente { get; set; }
        public int IdEstatusCliente { get; set; }
        public int IdIsoftDelete { get; set; }
        public int IdIauditable { get; set; }

        public virtual TbEstatusCliente IdEstatusClienteNavigation { get; set; }
        public virtual TbIauditable IdIauditableNavigation { get; set; }
        public virtual TbIsoftDelete IdIsoftDeleteNavigation { get; set; }
    }
}
