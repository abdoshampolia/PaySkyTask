using PaySky.Application.Contracts;

namespace PaySky.Application.Services
{
    public class EmiratesPurchaseService : IPurchaseService
    {
        public Task<string> ProcessPurchaseAsync(string nationalId)
        {
            try
            {
                return Task.FromResult("EmiratesBanckPurchase");
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
