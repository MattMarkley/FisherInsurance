using Microsoft.AspNetCore.Mvc;

[Route("customer")]

public class CustomerCareController : Controller 

{

    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    
    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the index of Customer/Claims");
    }


    [Route("claimstatus")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the index of Customer/ClaimStatus");
    }
}