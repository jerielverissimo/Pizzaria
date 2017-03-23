using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class EstoqueBLL
    {
        public static BindingList<EstoqueModel> EstoqueDB { get; set; }

        public static bool estoqueAcabando = false, faltaIngredientes = false;

        public static EstoqueModel GetPorId(int id)
        {
            return EstoqueDB.FirstOrDefault(x => x.IdEstoque == id);
        }

        public static EstoqueModel GetEstoqueByIngredienteId(int id)
        {
            return EstoqueDB.FirstOrDefault(x => x.IdIngrediente == id);
        }

        public static List<EstoqueModel> ListarPorFiltro(string Nome)
        {
            return EstoqueDB.Where(x => x.Ingrediente.Nome.StartsWith(Nome)).ToList();
        }

        public static void AdicionarQuantidade(int idIngrediente, int quantidadePizza, decimal quantidadeUnidade)
        {
            var estoque = EstoqueBLL.GetEstoqueByIngredienteId(idIngrediente);

            decimal quantidadeSaldo = estoque.Quantidade + quantidadeUnidade * quantidadePizza;

            /*if (quantidadeSaldo < 0)
            {
                throw new Exception(string.Format("Não existe saldo de {0} para concluir o pedido. Falta {1} {2} em estoque.", estoque.Ingrediente.Nome, quantidadeSaldo, estoque.Ingrediente.UnidadeMedida));
            }
            */

            //EstoqueBLL.EstoqueDB.Remove(estoque);

            estoque.Quantidade = quantidadeSaldo;
            //EstoqueBLL.EstoqueDB.Add(estoque);
        }

        public static void DeduzirQuantidade(int idIngrediente, int quantidadePizza, decimal quantidadeUnidade)
        {
            var estoque = EstoqueBLL.GetEstoqueByIngredienteId(idIngrediente);

            decimal quantidadeSaldo = estoque.Quantidade - quantidadeUnidade * quantidadePizza;

            

            if (quantidadeSaldo < 0)
            {
                //throw new Exception(string.Format("Não existe saldo de {0} para concluir o pedido. Falta {1} {2} em estoque.", estoque.Ingrediente.Nome, quantidadeSaldo, estoque.Ingrediente.UnidadeMedida));
                faltaIngredientes = true;
                
            }

            //EstoqueBLL.EstoqueDB.Remove(estoque);

            estoque.Quantidade = quantidadeSaldo;
            //EstoqueBLL.EstoqueDB.Add(estoque);

            if (estoque.Quantidade <= 40000)
            {
                //System.Windows.Forms.MessageBox.Show("Estoque menor que 40000");
                estoqueAcabando = true;
            }
        }

        public static void tahAcabando (int idIngrediente, System.Windows.Forms.ListBox lst)
        {
            var estoque = EstoqueBLL.GetEstoqueByIngredienteId(idIngrediente);

            string ingAcabando = estoque.Ingrediente.Nome;
            decimal qtdAcabando = estoque.Quantidade;

            //if (qtdAcabando <= 4000)
            
            

            lst.Items.Insert(0, ingAcabando + " em estoque " + qtdAcabando);
            
        }

    }
}
