using Pizzaria.Controle;
using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizzaria.Interface
{
    class Notificacao 
    {
        public static void notificacao_aviso(int ingrediente, System.Windows.Forms.Timer t)
        {
          var ingredi =IngredienteBLL.GetIngredienteById(ingrediente);
            if (Convert.ToInt32(ingredi) == 98888)
            {
                t.Enabled = true;

            }
        }
           
       

         // Para usar chama esse método e o primeiro parametro á a mensagem e o segundo é label lblAlert
         // para testar eu usei na lista do pedido com o evento de duplo clique

        public static void pushMessage(string msg, System.Windows.Forms.Label lbl)
        {
            lbl.Text = msg;
        }
    }
}
