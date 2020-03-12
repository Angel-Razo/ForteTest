using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbIsoftDelete
    {
        public TbIsoftDelete()
        {
            TbCliente = new HashSet<TbCliente>();
        }

        public int IdIsoftDelete { get; set; }
        public bool? Eliminado { get; set; }

        public virtual ICollection<TbCliente> TbCliente { get; set; }
    }
}
