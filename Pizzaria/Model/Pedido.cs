using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }

        public string Observacao { get; set; }

        public List<PizzaModel> Pizzas { get; set; }
    }
}
