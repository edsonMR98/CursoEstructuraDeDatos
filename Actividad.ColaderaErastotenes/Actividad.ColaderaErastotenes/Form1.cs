﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ColaderaErastotenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerPrimos_Click(object sender, EventArgs e)
        {
            Coladera col = new Coladera();

            txtbxPrimos.Text = col.eratostenes();
        }
    }
}
