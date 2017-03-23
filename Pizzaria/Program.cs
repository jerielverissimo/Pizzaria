using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Controle;
using Pizzaria.Model;

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

            IngredienteBLL.IngredienteDB = new List<IngredienteModel>();
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Farinha", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Trigo", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Mussarela", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Calabresa", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Bacon", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Provolone", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Catupiry", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Cebola", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Tomate", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Alho", UnidadeMedida = "KG" });
            IngredienteBLL.IngredienteDB.Add(new IngredienteModel() { IdIngrediente = idIngrediente++, Nome = "Azeitona", UnidadeMedida = "UN" });

            ReceitaBLL.ReceitaDB = new List<ReceitaModel>();
            ReceitaBLL.ReceitaDB.Add(new ReceitaModel() { IdReceita = ++idReceita, Nome = "Pizzaria C# Mussarela", Ingredientes = new List<ReceitaIngredienteModel>() });

            ReceitaIngredienteBLL.ReceitaIngredienteDB = new List<ReceitaIngredienteModel>();
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, IdIngrediente = 1, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(1) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, IdIngrediente = 2, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(2) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, IdIngrediente = 3, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(3) });
            ReceitaIngredienteBLL.ReceitaIngredienteDB.Add(new ReceitaIngredienteModel() { IdReceitaIngrediente = idReceitaIngrediente++, IdReceita = idReceita, IdIngrediente = 4, Receita = ReceitaBLL.GetPorId(idReceita), Ingrediente = IngredienteBLL.GetIngredienteById(4) });
            try { ReceitaBLL.GetPorId(idReceita).Ingredientes = ReceitaIngredienteBLL.GetByReceitaId(idReceita); } catch { }
            PizzaBLL.PizzaDB = new List<PizzaModel>();
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Pizzaria C# Mussarela 1", Sabor = "Mussarela", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Pizzaria C# Mussarela 2", Sabor = "Mussarela", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });
            PizzaBLL.PizzaDB.Add(new PizzaModel() { IdPizza = idPizza++, Nome = "Pizzaria C# Mussarela 3", Sabor = "Mussarela", IdReceita = idReceita, Receita = ReceitaBLL.GetPorId(idReceita) });

            EstoqueBLL.EstoqueDB = new List<EstoqueModel>();
            for (int i = 1; i < idIngrediente; i++)
            {
                EstoqueBLL.EstoqueDB.Add(new EstoqueModel() {IdEstoque= idEstoque++ , IdIngrediente = i, Ingrediente = IngredienteBLL.GetIngredienteById(i), Quantidade = 100000});
            }

            PedidoBLL.PedidoDB = new List<PedidoModel>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
