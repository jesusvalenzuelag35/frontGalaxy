using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Response
{
    public class ResponseDTO<T>
    {
        public bool Status { get; set; } = true;
        public string? Mensaje { get; set; }
        public T? Data { get; set; }
    }
}
