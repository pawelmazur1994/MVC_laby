
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_laby.Models
{
    public class ZajeciaModel
    {

        public int id;


        public DateTime termin;
        public string grupa;
        public string sala;



        public ZajeciaModel(DateTime termin, string grupa, string sala, int id)
        {
            this.termin = termin;
            this.grupa = grupa;
            this.sala = sala;
            this.id = id;
        }

        public override string ToString()
        {

            return $"id:{id},grupa:{grupa},termin:{termin},miejsce;{sala}";
        }
    }
}