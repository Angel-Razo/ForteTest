using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbIauditable
    {
        public TbIauditable()
        {
            TbCliente = new HashSet<TbCliente>();
        }

        public int IdIauditable { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? CreadoEl { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? ModificadoEl { get; set; }
        public string EliminadoPor { get; set; }
        public DateTime? EliminadoEl { get; set; }

        public virtual ICollection<TbCliente> TbCliente { get; set; }
    }
}
