using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialModulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            Modulo1 o = new Modulo1(num1, num2);
            MessageBox.Show("El numero menor es " + o.verificarNumeros());
            //Btn Verificar
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int basse = Convert.ToInt32(txtBase.Text);
            int Altura = Convert.ToInt32(txtAltura.Text);
            Modulo2 Area = new Modulo2(basse, Altura);
            MessageBox.Show(" El area del triangulo es: " + Area.AreaTriangulo());
            //Btn Area
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string invertir = Convert.ToString(txtPalabra.Text);
            Modulo4 PalabraReverso = new Modulo4();
            MessageBox.Show("La palabra invertida es: " + PalabraReverso.Reverse(invertir));
            //btn Invertir
        }
    }
}
