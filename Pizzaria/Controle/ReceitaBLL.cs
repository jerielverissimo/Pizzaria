using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controle
{
    public class ReceitaBLL
    {
        public static List<ReceitaModel> ReceitaDB { get; set; }

        public static ReceitaModel GetPorId(int id)
        {
            return ReceitaDB.FirstOrDefault(x => x.IdReceita == id);
        }
    }
}
