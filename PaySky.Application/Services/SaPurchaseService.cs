using PaySky.Application.Contracts;

namespace PaySky.Application.Services
{
    public class SaPurchaseService : IPurchaseService
    {
        public Task<string> ProcessPurchaseAsync(string nationalId)
        {
            try
            {
                return Task.FromResult("SaBanckPurchase");
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
