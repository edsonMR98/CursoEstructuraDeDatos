namespace Practica1.BitsYBytes
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjustarFecha = new System.Windows.Forms.Button();
            this.txtFechaAjustada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.prgsBarTanque = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picBxDireccion = new System.Windows.Forms.PictureBox();
            this.picBxSensor2 = new System.Windows.Forms.PictureBox();
            this.picBxSensor1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DateCalendar = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnDecodificar = new System.Windows.Forms.RadioButton();
            this.rdBtnAjustar = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSensor1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.AutoSize = true;
            this.btnProcesar.Location = new System.Drawing.Point(449, 75);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(95, 34);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(264, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(161, 29);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtPrueba
            // 
            this.txtPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrueba.Location = new System.Drawing.Point(518, 178);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(100, 19);
            this.txtPrueba.TabIndex = 3;
            this.txtPrueba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sensor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nivel En Tanque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sensor 1";
            // 
            // btnAjustarFecha
            // 
            this.btnAjustarFecha.AutoSize = true;
            this.btnAjustarFecha.Location = new System.Drawing.Point(285, 147);
            this.btnAjustarFecha.Name = "btnAjustarFecha";
            this.btnAjustarFecha.Size = new System.Drawing.Size(136, 34);
            this.btnAjustarFecha.TabIndex = 12;
            this.btnAjustarFecha.Text = "Ajustar Fecha";
            this.btnAjustarFecha.UseVisualStyleBackColor = true;
            this.btnAjustarFecha.Click += new System.EventHandler(this.btnAjustarFecha_Click);
            // 
            // txtFechaAjustada
            // 
            this.txtFechaAjustada.Location = new System.Drawing.Point(271, 214);
            this.txtFechaAjustada.Name = "txtFechaAjustada";
            this.txtFechaAjustada.Size = new System.Drawing.Size(161, 29);
            this.txtFechaAjustada.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Lectura";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(216, 280);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(129, 29);
            this.txtFecha.TabIndex = 14;
            // 
            // prgsBarTanque
            // 
            this.prgsBarTanque.Location = new System.Drawing.Point(338, 196);
            this.prgsBarTanque.MarqueeAnimationSpeed = 50;
            this.prgsBarTanque.Name = "prgsBarTanque";
            this.prgsBarTanque.Size = new System.Drawing.Size(100, 29);
            this.prgsBarTanque.Step = 30;
            this.prgsBarTanque.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 371);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picBxDireccion);
            this.tabPage1.Controls.Add(this.picBxSensor2);
            this.tabPage1.Controls.Add(this.picBxSensor1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.prgsBarTanque);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.txtPrueba);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picBxDireccion
            // 
            this.picBxDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxDireccion.Location = new System.Drawing.Point(518, 201);
            this.picBxDireccion.Name = "picBxDireccion";
            this.picBxDireccion.Size = new System.Drawing.Size(100, 50);
            this.picBxDireccion.TabIndex = 19;
            this.picBxDireccion.TabStop = false;
            // 
            // picBxSensor2
            // 
            this.picBxSensor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxSensor2.Location = new System.Drawing.Point(170, 185);
            this.picBxSensor2.Name = "picBxSensor2";
            this.picBxSensor2.Size = new System.Drawing.Size(100, 50);
            this.picBxSensor2.TabIndex = 18;
            this.picBxSensor2.TabStop = false;
            // 
            // picBxSensor1
            // 
            this.picBxSensor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxSensor1.Location = new System.Drawing.Point(45, 185);
            this.picBxSensor1.Name = "picBxSensor1";
            this.picBxSensor1.Size = new System.Drawing.Size(100, 50);
            this.picBxSensor1.TabIndex = 17;
            this.picBxSensor1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DateCalendar);
            this.tabPage2.Controls.Add(this.txtFechaAjustada);
            this.tabPage2.Controls.Add(this.btnAjustarFecha);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DateCalendar
            // 
            this.DateCalendar.Location = new System.Drawing.Point(184, 90);
            this.DateCalendar.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            this.DateCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.Size = new System.Drawing.Size(334, 29);
            this.DateCalendar.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.rdBtnDecodificar);
            this.panel1.Controls.Add(this.rdBtnAjustar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 66);
            this.panel1.TabIndex = 19;
            // 
            // rdBtnDecodificar
            // 
            this.rdBtnDecodificar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtnDecodificar.Checked = true;
            this.rdBtnDecodificar.FlatAppearance.BorderSize = 0;
            this.rdBtnDecodificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdBtnDecodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdBtnDecodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rdBtnDecodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBtnDecodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDecodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdBtnDecodificar.Location = new System.Drawing.Point(0, 0);
            this.rdBtnDecodificar.Name = "rdBtnDecodificar";
            this.rdBtnDecodificar.Size = new System.Drawing.Size(355, 66);
            this.rdBtnDecodificar.TabIndex = 20;
            this.rdBtnDecodificar.TabStop = true;
            this.rdBtnDecodificar.Text = "Decodificar Número";
            this.rdBtnDecodificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBtnDecodificar.UseVisualStyleBackColor = true;
            this.rdBtnDecodificar.CheckedChanged += new System.EventHandler(this.rdBtnDecodificar_CheckedChanged);
            // 
            // rdBtnAjustar
            // 
            this.rdBtnAjustar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtnAjustar.FlatAppearance.BorderSize = 0;
            this.rdBtnAjustar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdBtnAjustar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdBtnAjustar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rdBtnAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBtnAjustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnAjustar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdBtnAjustar.Location = new System.Drawing.Point(355, 0);
            this.rdBtnAjustar.Name = "rdBtnAjustar";
            this.rdBtnAjustar.Size = new System.Drawing.Size(355, 66);
            this.rdBtnAjustar.TabIndex = 21;
            this.rdBtnAjustar.Text = "Ajustar Fecha";
            this.rdBtnAjustar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBtnAjustar.UseVisualStyleBackColor = true;
            this.rdBtnAjustar.CheckedChanged += new System.EventHandler(this.rdBtnAjustar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bits y Bytes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSensor1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrueba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjustarFecha;
        private System.Windows.Forms.TextBox txtFechaAjustada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ProgressBar prgsBarTanque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnDecodificar;
        private System.Windows.Forms.RadioButton rdBtnAjustar;
        private System.Windows.Forms.PictureBox picBxSensor2;
        private System.Windows.Forms.PictureBox picBxSensor1;
        private System.Windows.Forms.PictureBox picBxDireccion;
        private System.Windows.Forms.DateTimePicker DateCalendar;
    }
}

