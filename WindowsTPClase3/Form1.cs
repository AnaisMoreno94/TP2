using EjecicioPractico2.Piezas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPAnimales.Animales;

namespace WindowsTPClase3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            PiezaCaballo caballo = new PiezaCaballo();

            MessageBox.Show(caballo.Mover());
        }

        private void btnCrearLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("3 años", "1.80mts", "50kg", "Medio");
            MessageBox.Show(leon.Imprimir() +" "+ leon.ImprimirComida());

        }

        private void btnCrearConejo_Click(object sender, EventArgs e)
        {
            Conejo bugss = new Conejo("1 año", "50 cm", "500gr", "Pelaje Gris");
            MessageBox.Show(bugss.Imprimir() + " " + bugss.ImprimirComida());

        }

        private void btnCrearLoro_Click(object sender, EventArgs e)
        {
            Loro pancho = new Loro("30 año", "30 cm", "200gr", "Plumas verdes");
            MessageBox.Show(pancho.Imprimir() + " " + pancho.ImprimirComida());
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {
            PiezaPeon peon = new PiezaPeon();

            MessageBox.Show(peon.Mover());

        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            PiezaTorre torre = new PiezaTorre();

            MessageBox.Show(torre.Mover());
        }
    }
}
