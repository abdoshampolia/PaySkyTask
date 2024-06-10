using PaySky.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using PaySky.Application.Common;

namespace PaySky.Application.Services
{
    public class BankPurchaseFactoryService
    {
        private readonly IServiceProvider _serviceProvider;

        public BankPurchaseFactoryService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPurchaseService GetPurchaseService(string nationalityId)
        {
            var key = string.Empty;

            Dictionary<string, bool> country = new Dictionary<string, bool>();

            country.Add("EGY", CountryIdValidation.ValidateEgyptID(nationalityId));
            country.Add("SU", CountryIdValidation.ValidateSaudiID(nationalityId));
            country.Add("UAE", CountryIdValidation.ValidateUAEID(nationalityId));

            foreach (var item in country)
            {
                if (item.Value)
                {
                    key = item.Key;
                }
            }

            return key switch
            {
                "EGY" => _serviceProvider.GetRequiredService<EgyPurchaseService>(),
                "UAE" => _serviceProvider.GetRequiredService<EmiratesPurchaseService>(),
                "SU" => _serviceProvider.GetRequiredService<SaPurchaseService>(),
                _ => throw new ArgumentException("Invalid nationality id", nameof(nationalityId)),
            };
        }

    }

}
