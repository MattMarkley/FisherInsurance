using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;


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

        Quote quote = new Quote 
         {
            Id = 345,

            Product = "Home Insurance",

            ExpireDate = DateTime.Now.AddDays(45),

            Price = 45.00M
         };


        return View(quote);
    }
}