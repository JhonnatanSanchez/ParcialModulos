using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialModulos
{
    class Modulo1
    {
        private int numero1;
        private int numero2;

        public Modulo1(int num1, int num2) {
            this.numero1 = num1;
            this.numero2 = num2;
        }

        public int verificarNumeros() {

            if (this.numero1 > this.numero2)
            {
                return  this.numero2;
            }
            else {
                return  this.numero1;
            }


            
        }

    }
}
