using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizzaria.Interface
{
    class Notificacao 
    {

       

         // Para usar chama esse método e o primeiro parametro á a mensagem e o segundo é label lblAlert
         // para testar eu usei na lista do pedido com o evento de duplo clique

        public static void pushMessage(string msg, System.Windows.Forms.Label lbl)
        {
            lbl.Text = msg;
        }
    }
}
