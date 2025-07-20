using Microsoft.AspNetCore.Mvc;

namespace PizzaManagment.Controllers;

[ApiController]
public class OrderController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateOrder()
    {
        throw new NotImplementedException();
    }
}