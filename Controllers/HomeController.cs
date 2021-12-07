using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using MVC_laby.Models;
using MVC_laby.Services;
using MVC_laby.Interfaces;
using MVC_laby.Context;
using System.Linq;

public class HomeController : Controller


{
    private readonly DziekanatContext _context;
    private readonly IObslugaBazyDanych obslugaBazyDanych;

    private readonly ILogger<HomeController> _logger;

    public HomeController(DziekanatContext context, IObslugaBazyDanych serwis, ILogger<HomeController> logger)
    {
        _context = context;
        obslugaBazyDanych = serwis;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("PlanZajec")]
    public IActionResult PlanZajec()
    {

        List<Zajecia> planZajec = _context.Zajecia.ToList();
        return View(planZajec);
    }

    [HttpGet]
    [Route("Students")]
    public IActionResult Students()
    {

        List<Student> students = _context.Student.ToList();

        return View(students);
    }
    [HttpDelete("{indeks}")]
    public ActionResult DeleteStudent([FromRoute] string indeks)
    {
        var isDeleted = obslugaBazyDanych.DeleteStudent(indeks);
        if (isDeleted)
        {
            return NoContent();
        }
        return NotFound();

    }





    [HttpPost]
    [Route("{controller}/Dodaj/{nazwa}")]

    public string DodajZajeciaDoPlanu(string nazwa)
    {
        // if (nazwa == null) return BadRequest();
        string komunikat = obslugaBazyDanych.DodajZajeciaDoPlanu(nazwa);
        return komunikat;
    }

    [HttpPost]
    [Route("AddStudent")]
    public ActionResult AddStudent([FromBody] Student student)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        obslugaBazyDanych.AddStudent(student);

        return Ok();

    }

}