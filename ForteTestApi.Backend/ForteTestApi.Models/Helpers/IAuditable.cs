using System;
using System.Collections.Generic;
using System.Text;

namespace ForteTestApi.Models.Helpers
{
    public class IAuditable
    {
        public string CreadoPor { get; set; }
        public DateTime CreadoEl { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime ModificadoEl { get; set; }
        public string EliminadoPor { get; set; }
        public DateTime EliminadoEl { get; set; }
    }
}
