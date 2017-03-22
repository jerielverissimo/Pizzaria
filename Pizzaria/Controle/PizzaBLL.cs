using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class PizzaBLL
    {
        public static List<PizzaModel> PizzaDB { get; set; }

        public static PizzaModel GetPizzaById(int id)
        {
            return PizzaDB.FirstOrDefault(x => x.IdPizza == id);
        }
    }
}
