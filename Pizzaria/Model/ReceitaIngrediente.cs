using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class ReceitaIngredienteModel
    {
        public int IdReceitaIngrediente { get; set; }

        public int IdReceita { get; set; }

        public int IdIngrediente { get; set; }

        public decimal Quantidade { get; set; }

        public ReceitaModel Receita { get; set; }

        public IngredienteModel Ingrediente { get; set; }
    }
}
