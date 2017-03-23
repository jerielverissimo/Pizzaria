using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class PizzaModel
    {
        public int IdPizza { get; set; }

        public int IdReceita { get; set; }

        public string Nome { get; set; }

        public string Sabor { get; set; }

        public ReceitaModel Receita { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
