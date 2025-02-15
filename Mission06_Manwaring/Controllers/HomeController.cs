using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Manwaring.Models;

namespace Mission06_Manwaring.Controllers;

public class HomeController : Controller
{
    private MovieAppContext _context;
    
    public HomeController(MovieAppContext temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult AboutPage()
    {
        return View();
    }
    
    [HttpGet] 
    public IActionResult Movie()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Movie(Movies movie)
    {
        
    }
}