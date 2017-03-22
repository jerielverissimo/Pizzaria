using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class ReceitaModel
    {
        public int IdReceita { get; set; }

        public string Nome { get; set; }

        public List<ReceitaIngredienteModel> Ingredientes { get; set; }
    }
}
