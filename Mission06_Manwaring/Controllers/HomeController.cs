using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
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
            return View("Confirmation", movie); 
        }

        return View("Confirmation");
    }

    // Linq
    public IActionResult List()
    {
        var applications = _context.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.Title)
            .ToList();
        return View(applications);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        return View("Movie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movies updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);

        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movies deletedInfo)
    {
        _context.Movies.Remove(deletedInfo);
        _context.SaveChanges();
        return RedirectToAction("List");
    }
}