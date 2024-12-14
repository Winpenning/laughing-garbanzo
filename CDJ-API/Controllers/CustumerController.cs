using CDJ_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CDJ_API.Controllers;

[ApiController][Route("Custumer")]
public class CustumerController : ControllerBase{

    [HttpGet][Route("")]
    public async Task<IActionResult> GetCustumer()
    {
        Custumer custumer = new Custumer("Ted","Cleiton","123456789",new DateOnly(1998,10,30));
        return Ok(custumer.GetJson());
    }
}