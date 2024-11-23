using DTO;
using DTO.Request;
using DTO.Response;

namespace Celulares.UI.Proxy.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseDTO<UsuarioDTO>> crearUsuario(UsuarioDTO entity);
        Task<LoginResponseDTO<UsuarioLogiadoDTO>> LoginUsuario(LoginRequestDTO entity);
    }
}
