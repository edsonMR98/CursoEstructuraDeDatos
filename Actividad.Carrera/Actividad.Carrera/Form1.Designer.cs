namespace Actividad.Carrera
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
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxC1 = new System.Windows.Forms.TextBox();
            this.txtbxC2 = new System.Windows.Forms.TextBox();
            this.txtbxTablero = new System.Windows.Forms.TextBox();
            this.txtbxGanador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.AutoSize = true;
            this.btnComenzar.Location = new System.Drawing.Point(198, 99);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(107, 34);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa Nombres de Corredores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Corredor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Corredor 2:";
            // 
            // txtbxC1
            // 
            this.txtbxC1.Location = new System.Drawing.Point(140, 50);
            this.txtbxC1.Name = "txtbxC1";
            this.txtbxC1.Size = new System.Drawing.Size(100, 29);
            this.txtbxC1.TabIndex = 4;
            // 
            // txtbxC2
            // 
            this.txtbxC2.Location = new System.Drawing.Point(364, 50);
            this.txtbxC2.Name = "txtbxC2";
            this.txtbxC2.Size = new System.Drawing.Size(100, 29);
            this.txtbxC2.TabIndex = 5;
            // 
            // txtbxTablero
            // 
            this.txtbxTablero.Location = new System.Drawing.Point(113, 152);
            this.txtbxTablero.Multiline = true;
            this.txtbxTablero.Name = "txtbxTablero";
            this.txtbxTablero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxTablero.Size = new System.Drawing.Size(276, 206);
            this.txtbxTablero.TabIndex = 6;
            // 
            // txtbxGanador
            // 
            this.txtbxGanador.Location = new System.Drawing.Point(251, 376);
            this.txtbxGanador.Name = "txtbxGanador";
            this.txtbxGanador.Size = new System.Drawing.Size(133, 29);
            this.txtbxGanador.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "El Ganador es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxGanador);
            this.Controls.Add(this.txtbxTablero);
            this.Controls.Add(this.txtbxC2);
            this.Controls.Add(this.txtbxC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Carrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxC1;
        private System.Windows.Forms.TextBox txtbxC2;
        private System.Windows.Forms.TextBox txtbxTablero;
        private System.Windows.Forms.TextBox txtbxGanador;
        private System.Windows.Forms.Label label4;
    }
}

