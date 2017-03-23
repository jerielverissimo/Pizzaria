using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class PedidoBLL
    {
        private static int Incremento = 0;
        public static BindingList<PedidoModel> PedidoDB { get; set; }


        public static PedidoModel GetPorId(int id)
        {
            return PedidoDB.FirstOrDefault(x => x.IdPedido == id);
        }

        public static string GetUltimoNumero()
        {
            return string.Concat("PED - ", Incremento++.ToString("000000"));
        }

        public static PedidoModel GetPedidoPorNumero(string NumeroPedido)
        {
            return PedidoDB.FirstOrDefault(x => x.NumeroPedido == NumeroPedido);
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

            foreach (var pizzaPed in Pedido.Pizzas)
            {
                foreach (var ingrediente in pizzaPed.Pizza.Receita.Ingredientes)
                {
                    EstoqueBLL.DeduzirQuantidade(ingrediente.IdIngrediente, 2, 100);
                }
            }
        }
    }
}
