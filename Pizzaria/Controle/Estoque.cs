using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Codig
{
    class Estoque
    {

        Pizza p = new Pizza();
        private int mussarela = 10000;

        public int Mussarela
        {
            get
            {
                return mussarela;
            }

            set
            {
                mussarela = value;
            }
        }

        public void selec(string t)
        {
            if (t == "mussarela")
                mussarela -= 100;
        }
    }
}
