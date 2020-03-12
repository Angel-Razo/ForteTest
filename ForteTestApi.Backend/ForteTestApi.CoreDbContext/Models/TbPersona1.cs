using System;
using System.Collections.Generic;

namespace ForteTestApi.CoreDbContext.Models
{
    public partial class TbPersona1
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public short? Edad { get; set; }
    }
}
