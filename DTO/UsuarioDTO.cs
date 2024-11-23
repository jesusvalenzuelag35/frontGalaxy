using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioDTO
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String celular { get; set; }
        public String correo { get; set; }
        public String password { get; set; }
        public String confirmPassword { get; set; }
    }
}
