using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Manwaring.Models;

namespace Mission06_Manwaring.Controllers;

// homecontroller class

public class HomeController : Controller
{
    private MovieAppContext _context;
    
    public HomeController(MovieAppContext temp)
    {
        _context = temp;
    }
    
    //main page
    public IActionResult Index()
    {
        return View();
    }
    
    //about page
    
    public IActionResult AboutPage()
    {
        return View();
    }
    
    //movie form below with GET
    [HttpGet] 
    public IActionResult Movie()
    {
        return View();
    }
    
    // saving new movie to DB with POST

    [HttpPost]
    public IActionResult Movie(Movies movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View("Confirmation"); 
        }

        return View("Confirmation");
    }
}