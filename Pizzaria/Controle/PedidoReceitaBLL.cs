using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class PedidoBLL
    {
        public static List<PedidoModel> PedidoDB { get; set; }

        public static PedidoModel GetPorId(int id)
        {
            return PedidoDB.FirstOrDefault(x => x.IdPedido == id);
        }

        public static void CriarPedido(PedidoModel Pedido)
        {
            if (Pedido == null)
            {
                throw new Exception("Pedido não pode ser nulo.");
            }

            if (Pedido.Pizzas == null || !Pedido.Pizzas.Any())
            {
                throw new Exception("Pedido deve possuir Pizzas.");
            }

            foreach (var pizza in Pedido.Pizzas)
            {
                foreach (var ingrediente in pizza.Receita.Ingredientes)
                {
                    EstoqueBLL.DeduzirQuantidade(ingrediente.IdIngrediente, 2, 100);
                }
            }
        }
    }
}
