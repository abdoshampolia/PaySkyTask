namespace PaySky.Application.Contracts
{
    public interface IPurchaseService
    {
        Task<string> ProcessPurchaseAsync(string nationalId);
    }
}
