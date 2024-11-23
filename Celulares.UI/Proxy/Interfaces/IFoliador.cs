using DTO.Response;
using DTO;

namespace Celulares.UI.Proxy.Interfaces
{
    public interface IFoliador
    {
        Task<FoliadorDTO> foliador();
    }
}
