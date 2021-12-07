using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_laby.Models;
using MVC_laby.Context;
using MVC_laby.Interfaces;
using Microsoft.Extensions.Logging;

namespace MVC_laby.Services
{
    public class ObslugaBazyDanych : IObslugaBazyDanych
    {


        private readonly DziekanatContext _dbContext;
        private readonly ILogger<ObslugaBazyDanych> _logger;
        public ObslugaBazyDanych(DziekanatContext dbcontext, ILogger<ObslugaBazyDanych> logger)
        {
            _dbContext = dbcontext;
            _logger = logger;
        }

        public string DodajZajeciaDoPlanu(string nazwa)
        {
            int id = new Random().Next();
            string komunikat = $"Zajęcia o nazwie {nazwa} zostały dodane do planu pod Id {id}";
            Console.WriteLine(komunikat);
            return komunikat;
        }

        public void AddStudent(Student dto)
        {

            _dbContext.Student.Add(dto);
            _dbContext.SaveChanges();


        }

        public bool DeleteStudent(string indeks)
        {
            var student = _dbContext.Student.FirstOrDefault(s => s.NumerIndeksu == indeks);
            if (student == null)
            {

                return false;
            }
            _dbContext.Student.Remove(student);
            return true;
        }

    }
}