using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text.Trim();

            // Telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            else if (rbOrdinario.Checked)
                tipoTelegrama = 'o';
            else
                tipoTelegrama = ' '; // Ninguno seleccionado

            // Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length;

            // Calculo el coste según el tipo
            if (tipoTelegrama == 'o')
            {
                // Ordinario
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 25 + 0.5 * (numPalabras - 10);
            }
            else if (tipoTelegrama == 'u')
            {
                // Urgente
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
            {
                coste = 0;
            }

            // Muestro el precio
            txtPrecio.Text = coste.ToString("0.00") + " euros";
        }
}
