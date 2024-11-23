using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Request
{
    public class CrearOrdenRequestDTO
    {
       
        public String FolioOrden { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String TipoEquipo { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String Marca { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String Modelo { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String Color { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String Observaciones { get; set; }
        public bool encendido { get; set; }
        public bool apagado { get; set; }
        public bool manipulado { get; set; }
        public bool mojado { get; set; }
        public bool roto { get; set; }
        public bool incompleto { get; set; }
        public String estetica { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String detalleDelServicio { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String tipobloqueo { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String costoTotal { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        public String anticipo { get; set; }
        public int IdOwner { get; set; }



    }
}
