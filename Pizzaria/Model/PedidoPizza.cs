using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class PedidoPizzaModel
    {
        public int IdPedido { get; set; }

        public int IdPizza { get; set; }

        public int Quantidade { get; set; }

        public bool ComBorda { get; set; }

        public PizzaModel Pizza { get; set; }

        public PedidoModel Pedido { get; set; }
    }
}
