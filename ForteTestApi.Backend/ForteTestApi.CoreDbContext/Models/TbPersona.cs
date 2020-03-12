using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbPersona
    {
        public int IdPersona { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public short? Edad { get; set; }
    }
}
