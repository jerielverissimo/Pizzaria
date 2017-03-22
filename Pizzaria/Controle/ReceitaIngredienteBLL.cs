using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class ReceitaIngredienteBLL
    {
        public static List<ReceitaIngredienteModel> ReceitaIngredienteDB { get; set; }

        public static ReceitaIngredienteModel GetReceitaIngredienteById(int id)
        {
            return ReceitaIngredienteDB.FirstOrDefault(x => x.IdReceita == id);
        }

        public static List<ReceitaIngredienteModel> GetByReceitaId(int id)
        {
            return ReceitaIngredienteDB.Where(x => x.IdReceita == id).ToList();
        }

        public static List<ReceitaIngredienteModel> GetByIngredienteId(int id)
        {
            return ReceitaIngredienteDB.Where(x => x.IdIngrediente == id).ToList();
        }
    }
}
