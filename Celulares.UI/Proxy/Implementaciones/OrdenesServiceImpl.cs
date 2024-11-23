using Celulares.UI.Proxy.Interfaces;
using DTO.Request;
using DTO.Response;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;

namespace Celulares.UI.Proxy.Implementaciones
{
    public class OrdenesServiceImpl : IOrdenesService
    {
        private readonly HttpClient _httpClient;
        
        public OrdenesServiceImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OrdenesDTO>> GetOrdenes()
        {
            List<OrdenesDTO> listadoOrdenres = new();
            
               
                listadoOrdenres = await _httpClient.GetFromJsonAsync<List<OrdenesDTO>>("GeneraFolioOrden/listar/ordenes");
            
           

            return listadoOrdenres;
        }

        public async Task<String> guardarOrden(CrearOrdenRequestDTO orden)
        {
            String mensaje = String.Empty;
            decimal numero = decimal.Parse(orden.costoTotal);
            try
            {
                var respuesta = await _httpClient.PostAsJsonAsync("GeneraFolioOrden/crear/orden", orden);
                var resultado = await respuesta.Content.ReadFromJsonAsync<OrdenCreadaRequestDTO>();
                if (resultado != null)
                {
                    mensaje = "Orden creada exitosamente";
                }else
                {
                    mensaje = "ocurrio algo";
                }

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return mensaje;
        }

        public async Task<ResponseBase> Eliminar(int numeroOrden)
        {
            var respuesta = await _httpClient.DeleteFromJsonAsync<ResponseBase>($"GeneraFolioOrden/borrar/orden/{numeroOrden}");
            if (respuesta != null)
            {
                return respuesta;
            }
            return new ResponseBase();
        }
    }
}
