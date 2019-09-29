namespace Practica2.ArchivosTextoYBinarios
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
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.txtbxArchivoBMP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxTamaño = new System.Windows.Forms.TextBox();
            this.txtbxAncho = new System.Windows.Forms.TextBox();
            this.txtbxAlto = new System.Windows.Forms.TextBox();
            this.txtbxBPP = new System.Windows.Forms.TextBox();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxApellido = new System.Windows.Forms.TextBox();
            this.txtbxTelefono = new System.Windows.Forms.TextBox();
            this.txtbxCP = new System.Windows.Forms.TextBox();
            this.txtbxEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo BMP:";
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarArchivo.AutoSize = true;
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(501, 33);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(189, 34);
            this.btnSeleccionarArchivo.TabIndex = 1;
            this.btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtbxArchivoBMP
            // 
            this.txtbxArchivoBMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxArchivoBMP.Location = new System.Drawing.Point(142, 35);
            this.txtbxArchivoBMP.Name = "txtbxArchivoBMP";
            this.txtbxArchivoBMP.ReadOnly = true;
            this.txtbxArchivoBMP.Size = new System.Drawing.Size(341, 29);
            this.txtbxArchivoBMP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño(bytes):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ancho:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alto:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bits por Pixel:";
            // 
            // txtbxTamaño
            // 
            this.txtbxTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxTamaño.Location = new System.Drawing.Point(176, 91);
            this.txtbxTamaño.Name = "txtbxTamaño";
            this.txtbxTamaño.ReadOnly = true;
            this.txtbxTamaño.Size = new System.Drawing.Size(180, 29);
            this.txtbxTamaño.TabIndex = 7;
            // 
            // txtbxAncho
            // 
            this.txtbxAncho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAncho.Location = new System.Drawing.Point(176, 134);
            this.txtbxAncho.Name = "txtbxAncho";
            this.txtbxAncho.ReadOnly = true;
            this.txtbxAncho.Size = new System.Drawing.Size(180, 29);
            this.txtbxAncho.TabIndex = 8;
            // 
            // txtbxAlto
            // 
            this.txtbxAlto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAlto.Location = new System.Drawing.Point(176, 177);
            this.txtbxAlto.Name = "txtbxAlto";
            this.txtbxAlto.ReadOnly = true;
            this.txtbxAlto.Size = new System.Drawing.Size(180, 29);
            this.txtbxAlto.TabIndex = 9;
            // 
            // txtbxBPP
            // 
            this.txtbxBPP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxBPP.Location = new System.Drawing.Point(176, 220);
            this.txtbxBPP.Name = "txtbxBPP";
            this.txtbxBPP.ReadOnly = true;
            this.txtbxBPP.Size = new System.Drawing.Size(180, 29);
            this.txtbxBPP.TabIndex = 10;
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.AutoSize = true;
            this.btnGenerarXml.Location = new System.Drawing.Point(476, 438);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(191, 34);
            this.btnGenerarXml.TabIndex = 11;
            this.btnGenerarXml.Text = "Guardar Información";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agenda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Codigo Postal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Edad:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(219, 368);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(193, 29);
            this.txtbxNombre.TabIndex = 18;
            // 
            // txtbxApellido
            // 
            this.txtbxApellido.Location = new System.Drawing.Point(219, 404);
            this.txtbxApellido.Name = "txtbxApellido";
            this.txtbxApellido.Size = new System.Drawing.Size(193, 29);
            this.txtbxApellido.TabIndex = 19;
            // 
            // txtbxTelefono
            // 
            this.txtbxTelefono.Location = new System.Drawing.Point(219, 440);
            this.txtbxTelefono.Name = "txtbxTelefono";
            this.txtbxTelefono.Size = new System.Drawing.Size(193, 29);
            this.txtbxTelefono.TabIndex = 20;
            // 
            // txtbxCP
            // 
            this.txtbxCP.Location = new System.Drawing.Point(219, 476);
            this.txtbxCP.Name = "txtbxCP";
            this.txtbxCP.Size = new System.Drawing.Size(193, 29);
            this.txtbxCP.TabIndex = 21;
            // 
            // txtbxEdad
            // 
            this.txtbxEdad.Location = new System.Drawing.Point(219, 512);
            this.txtbxEdad.Name = "txtbxEdad";
            this.txtbxEdad.Size = new System.Drawing.Size(193, 29);
            this.txtbxEdad.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 608);
            this.Controls.Add(this.txtbxEdad);
            this.Controls.Add(this.txtbxCP);
            this.Controls.Add(this.txtbxTelefono);
            this.Controls.Add(this.txtbxApellido);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.txtbxBPP);
            this.Controls.Add(this.txtbxAlto);
            this.Controls.Add(this.txtbxAncho);
            this.Controls.Add(this.txtbxTamaño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxArchivoBMP);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Archivos de Texto y Binarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtbxArchivoBMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxTamaño;
        private System.Windows.Forms.TextBox txtbxAncho;
        private System.Windows.Forms.TextBox txtbxAlto;
        private System.Windows.Forms.TextBox txtbxBPP;
        private System.Windows.Forms.Button btnGenerarXml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxApellido;
        private System.Windows.Forms.TextBox txtbxTelefono;
        private System.Windows.Forms.TextBox txtbxCP;
        private System.Windows.Forms.TextBox txtbxEdad;
    }
}

