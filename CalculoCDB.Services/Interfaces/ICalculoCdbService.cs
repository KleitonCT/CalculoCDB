using CalculoCDB.Domain.Request;
using CalculoCDB.Domain.Response;

namespace CalculoCDB.Services.Interfaces
{
    public interface ICalculoCdbService
    {
        CalculoCdbResponse CalcularCDB(CalculoCdbRequest request);
    }
}
