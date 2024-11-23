using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class LoginResponseDTO<T>
    {
        public bool status { get; set; }
        public String? mensaje { get; set; }
        public T data { get; set; }
    }

    public class UsuarioLogiadoDTO
    {
        public string NombreUSuario { get; set; }
        public string IdOwner { get; set; }
    }
}
