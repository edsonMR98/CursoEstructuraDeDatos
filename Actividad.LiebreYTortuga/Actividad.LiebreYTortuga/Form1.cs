using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.LiebreYTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            txtbxTablero.Text = "";
            Liebre libra = new Liebre();
            Tortuga torta = new Tortuga();

            while (libra.noPasos < 80 && torta.noPasos < 80)
            {
                libra.avanzar();
                txtbxTablero.Text += libra.ToString() + Environment.NewLine;
                torta.avanzar();
                txtbxTablero.Text += torta.ToString() + Environment.NewLine + Environment.NewLine;
            };

            if (libra.noPasos >= 80) txtbxGanador.Text = "Liebre";
            if (torta.noPasos >= 80) txtbxGanador.Text = "Tortuga";
            if (libra.noPasos >= 80 && torta.noPasos >= 80) txtbxGanador.Text = "Empate";
        }
    }
}
