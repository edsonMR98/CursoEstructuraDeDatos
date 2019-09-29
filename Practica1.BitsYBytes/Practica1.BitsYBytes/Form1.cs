using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.BitsYBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Int32 numero = Int32.Parse(txtNumero.Text);

            // evaluar los bits 1, 2, 3 (direccion)
            switch ((numero >> 1) & 7)
            {
                case 0:
                    {
                        txtPrueba.Text = "Norte";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.norte;
                        break;
                    }
                case 1:
                    {
                        txtPrueba.Text = "Noreste";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.noreste;
                        break;
                    }
                case 2:
                    {
                        txtPrueba.Text = "Este";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.este;
                        break;
                    }
                case 3:
                    {
                        txtPrueba.Text = "Sureste";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.sureste;
                        break;
                    }
                case 4:
                    {
                        txtPrueba.Text = "Sur";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.sur;
                        break;
                    }
                case 5:
                    {
                        txtPrueba.Text = "Suroeste";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.suroeste;
                        break;
                    }
                case 6:
                    {
                        txtPrueba.Text = "Oeste";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.oeste;
                        break;
                    }
                case 7:
                    {
                        txtPrueba.Text = "Noroeste";
                        picBxDireccion.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.noroeste;
                        break;
                    }
            }
            // evaluar los bits 4, 5 (tanque)
            switch ((numero >> 4) & 3)
            {
                case 1: // medio
                    {
                        prgsBarTanque.Style = ProgressBarStyle.Blocks;
                        prgsBarTanque.Value = 50;
                        break;
                    }
                case 2: // lleno
                    {
                        prgsBarTanque.Style = ProgressBarStyle.Blocks;
                        prgsBarTanque.Value = 100;
                        break;
                    }
                case 3: prgsBarTanque.Style = ProgressBarStyle.Marquee; // proceso llenando
                    break;
                default: // case 0, vacio
                    {
                        prgsBarTanque.Style = ProgressBarStyle.Blocks;
                        prgsBarTanque.Value = 2;
                    }
                    break;
            }
            // evaluar el bit 6 (sensor 2)
            switch ((numero >> 6) & 1)
            {
                case 1: picBxSensor2.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.on;
                    break;
                default: // case 0
                    picBxSensor2.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.off;
                    break;
            }
            // evaluar el bit 7 (sensor 1)
            switch ((numero >> 7) & 1)
            {
                case 1: picBxSensor1.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.on;
                    break;
                default: // case 0
                    picBxSensor1.BackgroundImage = Practica1.BitsYBytes.Properties.Resources.off;
                    break;
            }
 //evaluar los bits 17, 18, 19, 20, 21, 22, 23 (año)  +  /  +  13, 14, 15, 16 /mes)  +  /  +  8, 9, 10, 11, 12 (dias)
            txtFecha.Text = (((numero >> 17) & 127) + 1900)  + " / " + ((numero >> 13) & 15) + " / " + ((numero >> 8) & 31).ToString();
        }

        private void btnAjustarFecha_Click(object sender, EventArgs e)
        {
            UInt16 fecha = 0;

            fecha = Convert.ToUInt16(DateCalendar.Value.Year - 1900);
            fecha <<= 4;
            fecha += Convert.ToUInt16(DateCalendar.Value.Month);
            fecha <<= 5;
            fecha += Convert.ToUInt16(DateCalendar.Value.Day);
            txtFechaAjustada.Text = fecha.ToString();
        }

        private void rdBtnDecodificar_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void rdBtnAjustar_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnProcesar_Click(sender, e);
        }
    }
}