using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ListasCirculares
{
    public partial class Form1 : Form
    {
        Ruta ruta = new Ruta();

        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtBxMinutos.Text = "";
            txtBxNombre.Text = "";
            txtBxNBuscar.Text = "";
            txtBxPosicion.Text = "";
            txtBxNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtBxNombre.Text, int.Parse(txtBxMinutos.Text));

            ruta.agregarFinal(b);
            MessageBox.Show("Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            comBxBases.Items.Add(b.Nombre);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Base b = ruta.buscar(txtBxNBuscar.Text);

            if (b == null)
            {
                MessageBox.Show("Base NO Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                txtBxNombre.Text = b.Nombre;
                txtBxMinutos.Text = b.Minutos.ToString();
                MessageBox.Show("Base Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            Base b = ruta.eliminarInicio();
            txtBxTabla.Text = "Base Eliminada:" + Environment.NewLine + b.ToString();
            comBxBases.Items.Remove(b.Nombre);
        }

        private void btnEliminarUltima_Click(object sender, EventArgs e)
        {
            Base b = ruta.eliminarUltimo();
            txtBxTabla.Text = "Base Eliminada:" + Environment.NewLine + b.ToString();
            comBxBases.Items.Remove(b.Nombre);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = ruta.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Base b = new Base(txtBxNombre.Text, int.Parse(txtBxMinutos.Text));
            ruta.insertar(b, int.Parse(txtBxPosicion.Text));
            MessageBox.Show("Insertado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            comBxBases.Items.Add(b.Nombre);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Base b = ruta.eliminar(txtBxNombre.Text);
            txtBxTabla.Text = "Base Eliminada:" + Environment.NewLine + b.ToString();
            comBxBases.Items.Remove(b.Nombre);
        }

        private void btnMostrarRuta_Click(object sender, EventArgs e)
        {
            Base b = ruta.buscar(comBxBases.SelectedItem.ToString());
            txtBxTabla.Text = ruta.ruta(b, dtpHoraI.Value, dtpHoraF.Value);
        }
    }
}
