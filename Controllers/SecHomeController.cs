using Microsoft.AspNetCore.Mvc;


public class SecHomeController : Controller 

{
    public IActionResult Index()
    {
        //return Ok("This is the index of the SecHomeController");
        return View();
    }

    public IActionResult Quote()
    {
        //return Ok("This is the index of the SecHome/Quote");
        return View();
    }
}