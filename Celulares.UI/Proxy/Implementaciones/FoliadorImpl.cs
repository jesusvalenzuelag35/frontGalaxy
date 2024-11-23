using Celulares.UI.Proxy.Interfaces;
using DTO;
using DTO.Response;
using System.Net.Http.Json;

namespace Celulares.UI.Proxy.Implementaciones
{
    public class FoliadorImpl : IFoliador
    {
        private readonly HttpClient _httpClient;
        public FoliadorImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<FoliadorDTO> foliador()
        {
            
            var foliador = new FoliadorDTO();
            try
            {
                var respose = await _httpClient.GetFromJsonAsync<FoliadorDTO>("GeneraFolioOrden/folio");
                if (respose != null)
                {
                    foliador = respose;
                }else
                {
                    foliador.folio = "0";
                }
              
                
                
            }
            catch (Exception ex)
            {

            }
            return foliador;
           
        }
    }
}
