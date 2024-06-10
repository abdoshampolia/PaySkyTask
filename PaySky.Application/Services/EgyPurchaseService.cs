using PaySky.Application.Contracts;

namespace PaySky.Application.Services
{
    public class EgyPurchaseService : IPurchaseService
    {
        public Task<string> ProcessPurchaseAsync(string nationalId)
        {
            try
            {
                return Task.FromResult("EgyBanckPurchase");
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
