using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_laby.Models
{
    public class OsobaModel
    {
        private int _id;
        private string _imie;
        private string _nazwisko;

        public string Inicjaly;


        public OsobaModel(int id, string imie, string nazwisko)
        {
            _id = id;
            _imie = imie;
            _nazwisko = nazwisko;
            Inicjaly = $"{imie.Substring(0, 1)}. {nazwisko.Substring(0, 1)}.";


        }
        public override string ToString()
        {

            return $"id:{_id},imie:{_imie},nazwisko:{_nazwisko}";
        }

    }
}
