using Microsoft.AspNetCore.Mvc;
using PaySky.Application.Services;

namespace PaySky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly BankPurchaseFactoryService _bankPurchaseFactoryService;

        public PurchaseController(BankPurchaseFactoryService bankPurchaseFactoryService)
        {
            _bankPurchaseFactoryService = bankPurchaseFactoryService;
        }

        [HttpPost]
        public IActionResult Purchase([FromBody] string nationalId)
        {

            //Sample Id To Test 
            //UAE: 784-1995-1234567-8
            //EGY: 29802060123456
            //SU : 1023456789
            var paymentService = _bankPurchaseFactoryService.GetPurchaseService(nationalId);

            var result = paymentService.ProcessPurchaseAsync(nationalId);

            return Ok(result);
        }
    }
}
