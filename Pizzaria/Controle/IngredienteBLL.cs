using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class IngredienteBLL
    {
        public static List<IngredienteModel> IngredienteDB { get; set; }

        public static IngredienteModel GetIngredienteById(int id)
        {
            return IngredienteDB.FirstOrDefault(x => x.IdIngrediente == id);
        }
    }
}
