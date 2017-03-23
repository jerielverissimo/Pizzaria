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
      /*  public static void notificacao_aviso(int ingrediente, System.Windows.Forms.Timer t)
        {
          var ingredi =IngredienteBLL.GetIngredienteById(ingrediente);
            if (Convert.ToInt32(ingredi) == 98888)
            {
                t.Enabled = true;

            }
        }
           
       */

         // Para usar chama esse método e o primeiro parametro á a mensagem e o segundo é label lblAlert o terceiro é o tmAlert
         // o quarto é o ptbAlert e por fim o ultimo é o panAlert, tem que ser especificamente esses paramentros do form.
         // para testar eu usei na lista do pedido com o evento de duplo clique

        public static void pushMessage(string msg, System.Windows.Forms.Label lbl, System.Windows.Forms.Timer t,
            System.Windows.Forms.PictureBox ptb, System.Windows.Forms.Panel pan)
        {
            lbl.Text = msg; // seta a menssagem
            if (!frmPrincipal.ativarAlert) t.Enabled = true; // ativa a notificação

            // centraliza a msg e o icone
            lbl.Left = (pan.Width - lbl.Width) / 2;
            ptb.Left = lbl.Location.X - 50;
        }


       /* public static void getEstoqueAcabando (int idIngrediente)
        {
            var estoque = EstoqueBLL.GetEstoqueByIngredienteId(idIngrediente);

            if (estoque.Quantidade <= 4000)
            {

            }
        }*/
    }
}
