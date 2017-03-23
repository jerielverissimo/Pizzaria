using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }

        public string NumeroPedido { get; set; }

        public string Observacao { get; set; }

        public bool Concluido { get; set; }

        public BindingList<PedidoPizzaModel> Pizzas { get; set; }
    }
}
