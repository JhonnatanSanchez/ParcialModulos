using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialModulos
{
    class Modulo2
    {
        private int n1;
        private int n2; 
            
        public Modulo2(int basse, int altura)
        {
            this.n1 = basse;
            this.n2 = altura;
        }
        public int AreaTriangulo()
        {
            int Area = 0;
            Area = (this.n1 * this.n2) / 2;
            return Area;
        }
 
    }
}
