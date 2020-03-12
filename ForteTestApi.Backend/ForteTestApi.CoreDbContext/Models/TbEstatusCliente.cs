using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbEstatusCliente
    {
        public TbEstatusCliente()
        {
            TbCliente = new HashSet<TbCliente>();
        }

        public int IdEstatusCliente { get; set; }
        public string Descripcion { get; set; }
        public bool? EstatusClienteId { get; set; }

        public virtual ICollection<TbCliente> TbCliente { get; set; }
    }
}
