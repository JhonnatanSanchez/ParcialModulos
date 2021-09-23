using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialModulos
{
    class Modulo3
    {

        public List<string> contadorLetras(string texto) {
            
            List<string> letras = new List<string>();
            char a = 'x';
            int contador = 0;
            string resultado;

            char[] caracter = texto.ToCharArray();

            for (int j = 0; j < caracter.Length; j++)
            {
                for (int i = 0; i < caracter.Length; i++)
                {
                    if (caracter[i] == caracter[j])
                    {
                        a = caracter[i];
                        contador += 1;
                    }
                }
                resultado = a.ToString() + " : " + contador;
                letras.Add(resultado);
                contador = 0;
            }

            return letras;
        }

    }
}
