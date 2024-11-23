using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Request
{
    public class LoginRequestDTO
    {
        [Required(ErrorMessage =Constantes.Required_Error)]
        public String Usuario { get; set; }
        [Required(ErrorMessage = Constantes.Required_Error)]
        [Display(Name = Constantes.Required_Password)] 
        public String password { get; set; }
    }
}
