using Celulares.UI.Proxy.Interfaces;
using DTO;
using DTO.Request;
using DTO.Response;
using System.Net.Http.Json;

namespace Celulares.UI.Proxy.Implementaciones
{
    public class UsuarioServiceImpl : IUsuarioService
    {
        private readonly HttpClient _httpClient;
        public UsuarioServiceImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResponseDTO<UsuarioDTO>> crearUsuario(UsuarioDTO entity)
        {
            ResponseDTO < UsuarioDTO > result = new ResponseDTO<UsuarioDTO> ();
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Owner/registrar", entity);
                result = await response.Content.ReadFromJsonAsync<ResponseDTO<UsuarioDTO>>();
            }
            catch (Exception ex)
            {
                String resultado = ex.Message;
            }
            

            return result;
        }

        public async Task<LoginResponseDTO<UsuarioLogiadoDTO>> LoginUsuario(LoginRequestDTO entity)
        {
            var result = new LoginResponseDTO<UsuarioLogiadoDTO>();
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Owner/login", entity);
                result = await response.Content.ReadFromJsonAsync<LoginResponseDTO<UsuarioLogiadoDTO>>();
            }
            catch (Exception ex)
            {
                String resultado = ex.Message;
            }        
 


            return result;
        }
    }
}
