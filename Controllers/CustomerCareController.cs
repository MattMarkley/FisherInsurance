using Microsoft.AspNetCore.Mvc;

[Route("customer")]

public class CustomerCareController : Controller 

{

    public IActionResult Index()
    {
        //return Ok("This is the index of the CustomerCareController");
        return View();
    }
    
    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        //return Ok("This is the index of Customer/Claims");
        return View();
    }


    [Route("claimstatus")]
    public IActionResult ClaimHistory()
    {
        //return Ok("This is the index of Customer/ClaimStatus");
        return View();
    }
}