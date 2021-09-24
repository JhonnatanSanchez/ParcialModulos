using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParcialModulos
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.text.normalizationform?view=net-5.0
    class Modulo5
    {

        private string texto;


        public Modulo5(string txt) {
            this.texto = txt;
        }


        private List<string> sacarLetras() {

            string texto2 = Regex.Replace(this.texto.Normalize(NormalizationForm.FormD), @"[^a-zA-z]+", "");
            char[] caracter = texto2.ToCharArray();
            List<string> cadena = new List<string>();
            foreach (char letra in caracter)
            {
                cadena.Add(letra.ToString().ToLower());
            }
            return cadena;
        }

        public string buscarPangrama() {
            int cantidadLetras;
            HashSet<string> listaConDuplicidad = new HashSet<string>(sacarLetras());
            List<string> listaSinDuplicidad = listaConDuplicidad.ToList();
            listaSinDuplicidad.Sort();
            string lista = listaSinDuplicidad.Aggregate((x, y) => x + ", " + y);
            cantidadLetras = listaSinDuplicidad.Count;

            if (cantidadLetras == 27)
            {
                return "Pangrama colombiano \n" + "Letras del abecedario : " + lista + "\nCantidad Letras :" + cantidadLetras;
            }
            else if (cantidadLetras == 26)
            {
                return "Pangrama Ingles \n" + "Letras del abecedario : " + lista + "\nCantidad Letras :" + cantidadLetras;
            }
            else
            {
                return "No es un Pangrama \n" + "Letras del abecedario : "+ lista + "\nCantidad Letras :" + cantidadLetras;
            }
        }
    }
}
