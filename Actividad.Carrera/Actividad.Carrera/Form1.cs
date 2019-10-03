using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Corredor c1 = new Corredor(txtbxC1.Text);
            Corredor c2 = new Corredor(txtbxC2.Text);

            Carrera carrera = new Carrera(c1, c2);


            txtbxTablero.Text = carrera.realizar();

            txtbxGanador.Text = carrera.ganador;
        }
    }
}
