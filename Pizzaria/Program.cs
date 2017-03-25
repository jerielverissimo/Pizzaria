using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Controle;
using Pizzaria.Model;
using System.ComponentModel;

namespace Pizzaria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int idIngrediente = 1, idReceita = 0, idReceitaIngrediente = 1, idPizza = 1, idEstoque = 1;

            // Lista de ingredientes que estão em estoque

            IngredienteBLL.IngredienteDB = new List<IngredienteModel>();
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Farinha", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Mussarela", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Calabresa", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Frango", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Provolone", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Catupiry", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Cebola", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Tomate", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Alho", UnidadeMedida = "g" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Azeitona", UnidadeMedida = "g" });


            // Cria receita da Pizza de Mussarela
            
            ReceitaBLL.ReceitaDB = new List<ReceitaModel>();
            ReceitaBLL.ReceitaDB.Add(new ReceitaModel() { IdReceita = ++idReceita, Nome = "Mussarela", Ingredientes = new List<ReceitaIngredienteModel>() });

            ReceitaIngredienteBLL.ReceitaIngredienteDB = new List<ReceitaIngredienteModel>();
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 1, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(1) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 2, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(2) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 8, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(8) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 50, IdIngrediente = 10, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(10) });
            try { ReceitaBLL.GetPorId(idReceita).Ingredientes = ReceitaIngredienteBLL.GetByReceitaId(idReceita); } catch { }
            PizzaBLL.PizzaDB = new List<PizzaModel>();
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Mussarela", Sabor = "Mussarela", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });

            // Cria receida da Pizza de Calabresa

            ReceitaBLL.ReceitaDB = new List<ReceitaModel>();
            ReceitaBLL.ReceitaDB.Add(new ReceitaModel() { IdReceita = ++idReceita, Nome = "Calabresa", Ingredientes = new List<ReceitaIngredienteModel>() });

            ReceitaIngredienteBLL.ReceitaIngredienteDB = new List<ReceitaIngredienteModel>();
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 1, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(1) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 2, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(2) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 3, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(3) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 7, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(7) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 8, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(8) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 50, IdIngrediente = 10, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(10) });
            try { ReceitaBLL.GetPorId(idReceita).Ingredientes = ReceitaIngredienteBLL.GetByReceitaId(idReceita); } catch { }
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Calabresa", Sabor = "Calabresa", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });

            // Cria receita de Frango

            ReceitaBLL.ReceitaDB = new List<ReceitaModel>();
            ReceitaBLL.ReceitaDB.Add(new ReceitaModel() { IdReceita = ++idReceita, Nome = "Frango", Ingredientes = new List<ReceitaIngredienteModel>() });

            ReceitaIngredienteBLL.ReceitaIngredienteDB = new List<ReceitaIngredienteModel>();
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 1, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(1) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 2, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(2) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 200, IdIngrediente = 3, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(3) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 6, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(6) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 100, IdIngrediente = 8, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(8) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, Quantidade = 50, IdIngrediente = 10, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(10) });
            try { ReceitaBLL.GetPorId(idReceita).Ingredientes = ReceitaIngredienteBLL.GetByReceitaId(idReceita); } catch { }
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Frango", Sabor = "Frango", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });

            EstoqueBLL.EstoqueDB = new BindingList<EstoqueModel>();
            for (int i = 1; i < idIngrediente; i++)
            {
                EstoqueBLL.EstoqueDB.Add(new EstoqueModel() { IdEstoque = idEstoque++, IdIngrediente = i, Ingrediente = IngredienteBLL.GetIngredienteById(i), Quantidade = 100000 });
            }

            PedidoBLL.PedidoDB = new BindingList<PedidoModel>();
            //PedidoBLL.PedidoDB.Add(new PedidoModel() { IdPedido = 1, NumeroPedido = "PED - 000000" });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
