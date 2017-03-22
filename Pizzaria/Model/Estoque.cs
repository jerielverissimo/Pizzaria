using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class EstoqueModel
    {
        public int IdEstoque { get; set; }

        //Sempre apenas um na lista
        public int IdIngrediente { get; set; }

        public decimal Quantidade { get; set; }

        public IngredienteModel Ingrediente { get; set; }
    }
}
