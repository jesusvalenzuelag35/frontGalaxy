using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class OrdenCreadaRequestDTO
    {
        public int numeroOrden { get; set; }
        public String FolioOrden { get; set; }
        public String TipoEquipo { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public String Observaciones { get; set; }
        public bool encendido { get; set; }
        public bool apagado { get; set; }
        public bool manipulado { get; set; }
        public bool mojado { get; set; }
        public bool roto { get; set; }
        public bool incompleto { get; set; }
        public String estetica { get; set; }
        public String detalleDelServicio { get; set; }
        public String tipobloqueo { get; set; }
        public Decimal costoTotal { get; set; }
        public Decimal anticipo { get; set; }
        public int IdOwner { get; set; }
    }
}
