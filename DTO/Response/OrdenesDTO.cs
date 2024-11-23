using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class OrdenesDTO
    {
        public int numeroOrden { get; set; }
        public String FolioOrden { get; set; }
        public String TipoEquipo { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public String Observaciones { get; set; }
    }
}
