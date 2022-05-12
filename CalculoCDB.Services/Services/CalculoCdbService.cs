using CalculoCDB.Domain.Request;
using CalculoCDB.Domain.Response;
using CalculoCDB.Services.Interfaces;

namespace CalculoCDB.Services.Services
{
    public class CalculoCdbService : ICalculoCdbService
    {
        private const decimal TB = 1.08M;
        private const decimal CDI = 0.09M;
        public CalculoCdbResponse CalcularCDB(CalculoCdbRequest request)
        {
            CalculoCdbResponse response = new CalculoCdbResponse();

            for (int i = 0; i < request.PrazoMeses; i++)
            {
                response.ResultadoBruto += request.ValorInvestimento * (1 + (CDI * TB));
            }

            response.ResultadoLiquido = response.ResultadoBruto - (response.ResultadoBruto * GetImposto(request.PrazoMeses));

            return response;
        }

        private decimal GetImposto(int meses)
        {
            if (meses <= 6)
                return 0.225M;
            else if (meses <= 12)
                return 0.20M;
            else if (meses <= 14)
                return 0.175M;
            else
                return 0.15M;
        }
    }
}
