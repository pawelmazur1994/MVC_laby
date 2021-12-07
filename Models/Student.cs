using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_laby.Models
{

    public class Student
    {
        public int ID { get; set; }
        public string NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string AdresZamieszkania { get; set; }
        public List<ZajeciaModel> PlanZajec;






    }
}
