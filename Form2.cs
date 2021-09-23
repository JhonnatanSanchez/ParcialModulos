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
    public partial class Form2 : Form
    {
        char[] PalabrasAdivinadas;
        int Oportunidades;
        char[] PalabrasSeleccionada;
        char[] Alfabeto;
        public Form2()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            //Valores iniciales del juego
            flFichasJuego.Controls.Clear();
            flFichasJuego.Enabled = true;
            picAhorcado.Image = null;
            lblPerder.Visible = false;
            Oportunidades = 0;//fallar

            string Palabras = (txtPalabra.Text);
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ".ToCharArray();
            PalabrasSeleccionada = Palabras.ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabrasSeleccionada;

            //Se crea un ciclo que crea el alfabeto
            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = " ";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasJuego.Controls.Add(btnLetra);
            }

            flPalabra.Controls.Clear();
            for (int ValorLetra = 0; ValorLetra < PalabrasSeleccionada.Length; ValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabrasSeleccionada[ValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Purple;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinaste" + ValorLetra.ToString();
                Letra.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ahorcado1));
                flPalabra.Controls.Add(Letra);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrada = false;
            //Boton presionado se desactiva
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            //Compara la letra seleccionada con las letras de la palabra
            for (int Revisar = 0; Revisar < PalabrasAdivinadas.Length; Revisar++)
            {
                if (PalabrasAdivinadas[Revisar] == Char.Parse(btn.Text))
                {
                    //Si existe la letra, actualiza la palabra agregando el valor correspondiente
                    Button tbx = this.Controls.Find("Adivinaste" + Revisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[Revisar].ToString();
                    PalabrasAdivinadas[Revisar] = '-';
                    encontrada = true;
                }
            }
            //Verifica si todas las letras de la palabra estan destapadas
            bool Ganaste = true;
            for (int AnalizarGanador = 0; AnalizarGanador < PalabrasAdivinadas.Length; AnalizarGanador++)
            {
                //Si el usuario tiene letras pendientes por destapar se cambia el estatus
                if (PalabrasAdivinadas[AnalizarGanador] != '-')
                {
                    Ganaste = false;
                }
            }
            //Si el estatus de la variable no cambia quiere decir que el jugador gano
            if (Ganaste)
            {
                MessageBox.Show("Ganaste");
            }
            //Si no se encuentra ninguna letra de la palabra
            if (!encontrada)
            {
                Oportunidades = Oportunidades + 1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunidades);

                //Si las oportunidades ya se acabaron (Mostrar Palabra)
                if (Oportunidades == 7)
                {
                    lblPerder.Visible = true;
                    //Muestra la plabra que el usuario intentaba descubrir
                    for (int ValorLetra = 0; ValorLetra < PalabrasSeleccionada.Length; ValorLetra++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinaste" + ValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }
                    //Desactiva las fichas y cambia el boton de reinicio
                    flFichasJuego.Enabled = false;
                }

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
