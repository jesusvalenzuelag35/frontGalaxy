using DTO.Request;
using DTO.Response;

namespace Celulares.UI.Proxy.Interfaces
{
    public interface IOrdenesService
    {
        Task<List<OrdenesDTO>> GetOrdenes();
        Task<String> guardarOrden(CrearOrdenRequestDTO orden);
        Task<ResponseBase> Eliminar(int numeroOrden);
    }
}
