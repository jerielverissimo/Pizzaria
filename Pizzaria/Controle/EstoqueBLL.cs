using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class EstoqueBLL
    {
        public static List<EstoqueModel> EstoqueDB { get; set; }

        public static EstoqueModel GetPorId(int id)
        {
            return EstoqueDB.FirstOrDefault(x => x.IdEstoque == id);
        }

        public static EstoqueModel GetEstoqueByIngredienteId(int id)
        {
            return EstoqueDB.FirstOrDefault(x => x.IdIngrediente == id);
        }

        public static void DeduzirQuantidade(int idIngrediente, int quantidadePizza, decimal quantidadeUnidade)
        {
            var estoque = EstoqueBLL.GetEstoqueByIngredienteId(idIngrediente);

            decimal quantidadeSaldo = estoque.Quantidade - quantidadeUnidade * quantidadePizza;

            if (quantidadeSaldo < 0)
            {
                throw new Exception(string.Format("Não existe saldo de {0} para concluir o pedido. Falta {1} {2} em estoque.", estoque.Ingrediente.Nome, quantidadeSaldo, estoque.Ingrediente.UnidadeMedida));
            }

            estoque.Quantidade = quantidadeSaldo;
        }
    }
}
