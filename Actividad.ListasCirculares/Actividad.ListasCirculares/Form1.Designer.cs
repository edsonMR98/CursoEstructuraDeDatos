namespace Actividad.ListasCirculares
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBxNBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxMinutos = new System.Windows.Forms.TextBox();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxTabla = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltima = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxPosicion = new System.Windows.Forms.TextBox();
            this.comBxBases = new System.Windows.Forms.ComboBox();
            this.btnMostrarRuta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraI = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraF = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(19, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(260, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBxNBuscar
            // 
            this.txtBxNBuscar.Location = new System.Drawing.Point(423, 11);
            this.txtBxNBuscar.Name = "txtBxNBuscar";
            this.txtBxNBuscar.Size = new System.Drawing.Size(145, 29);
            this.txtBxNBuscar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre a buscar:";
            // 
            // txtBxMinutos
            // 
            this.txtBxMinutos.Location = new System.Drawing.Point(102, 45);
            this.txtBxMinutos.Name = "txtBxMinutos";
            this.txtBxMinutos.Size = new System.Drawing.Size(140, 29);
            this.txtBxMinutos.TabIndex = 1;
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(102, 11);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(140, 29);
            this.txtBxNombre.TabIndex = 0;
            // 
            // txtBxTabla
            // 
            this.txtBxTabla.Location = new System.Drawing.Point(12, 257);
            this.txtBxTabla.Multiline = true;
            this.txtBxTabla.Name = "txtBxTabla";
            this.txtBxTabla.Size = new System.Drawing.Size(555, 156);
            this.txtBxTabla.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.Location = new System.Drawing.Point(489, 121);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(78, 34);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.AutoSize = true;
            this.btnEliminarPrimero.Location = new System.Drawing.Point(260, 81);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(159, 34);
            this.btnEliminarPrimero.TabIndex = 8;
            this.btnEliminarPrimero.Text = "Eliminar Primera";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarUltima
            // 
            this.btnEliminarUltima.AutoSize = true;
            this.btnEliminarUltima.Location = new System.Drawing.Point(424, 81);
            this.btnEliminarUltima.Name = "btnEliminarUltima";
            this.btnEliminarUltima.Size = new System.Drawing.Size(144, 34);
            this.btnEliminarUltima.TabIndex = 9;
            this.btnEliminarUltima.Text = "Eliminar Ultima";
            this.btnEliminarUltima.UseVisualStyleBackColor = true;
            this.btnEliminarUltima.Click += new System.EventHandler(this.btnEliminarUltima_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(480, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.AutoSize = true;
            this.btnInsertar.Location = new System.Drawing.Point(260, 121);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(81, 34);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Posicion:";
            // 
            // txtBxPosicion
            // 
            this.txtBxPosicion.Location = new System.Drawing.Point(102, 126);
            this.txtBxPosicion.Name = "txtBxPosicion";
            this.txtBxPosicion.Size = new System.Drawing.Size(140, 29);
            this.txtBxPosicion.TabIndex = 12;
            // 
            // comBxBases
            // 
            this.comBxBases.FormattingEnabled = true;
            this.comBxBases.Location = new System.Drawing.Point(102, 173);
            this.comBxBases.Name = "comBxBases";
            this.comBxBases.Size = new System.Drawing.Size(139, 32);
            this.comBxBases.TabIndex = 14;
            this.comBxBases.Text = "Bases";
            // 
            // btnMostrarRuta
            // 
            this.btnMostrarRuta.AutoSize = true;
            this.btnMostrarRuta.Location = new System.Drawing.Point(216, 211);
            this.btnMostrarRuta.Name = "btnMostrarRuta";
            this.btnMostrarRuta.Size = new System.Drawing.Size(125, 34);
            this.btnMostrarRuta.TabIndex = 15;
            this.btnMostrarRuta.Text = "Mostrar Ruta";
            this.btnMostrarRuta.UseVisualStyleBackColor = true;
            this.btnMostrarRuta.Click += new System.EventHandler(this.btnMostrarRuta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Base:";
            // 
            // dtpHoraI
            // 
            this.dtpHoraI.CustomFormat = "hh:mm";
            this.dtpHoraI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraI.Location = new System.Drawing.Point(321, 174);
            this.dtpHoraI.Name = "dtpHoraI";
            this.dtpHoraI.ShowUpDown = true;
            this.dtpHoraI.Size = new System.Drawing.Size(69, 29);
            this.dtpHoraI.TabIndex = 19;
            // 
            // dtpHoraF
            // 
            this.dtpHoraF.CustomFormat = "hh:mm";
            this.dtpHoraF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraF.Location = new System.Drawing.Point(498, 174);
            this.dtpHoraF.Name = "dtpHoraF";
            this.dtpHoraF.ShowUpDown = true;
            this.dtpHoraF.Size = new System.Drawing.Size(69, 29);
            this.dtpHoraF.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 425);
            this.Controls.Add(this.dtpHoraF);
            this.Controls.Add(this.dtpHoraI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMostrarRuta);
            this.Controls.Add(this.comBxBases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxPosicion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEliminarUltima);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtBxTabla);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.txtBxMinutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxNBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Listas Circulares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBxNBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxMinutos;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.TextBox txtBxTabla;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltima;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxPosicion;
        private System.Windows.Forms.ComboBox comBxBases;
        private System.Windows.Forms.Button btnMostrarRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHoraI;
        private System.Windows.Forms.DateTimePicker dtpHoraF;
    }
}

