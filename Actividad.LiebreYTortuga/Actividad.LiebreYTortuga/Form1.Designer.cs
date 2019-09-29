namespace Actividad.LiebreYTortuga
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxGanador = new System.Windows.Forms.TextBox();
            this.txtbxTablero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "El Ganador es:";
            // 
            // txtbxGanador
            // 
            this.txtbxGanador.Location = new System.Drawing.Point(260, 344);
            this.txtbxGanador.Name = "txtbxGanador";
            this.txtbxGanador.Size = new System.Drawing.Size(133, 29);
            this.txtbxGanador.TabIndex = 16;
            // 
            // txtbxTablero
            // 
            this.txtbxTablero.Location = new System.Drawing.Point(122, 120);
            this.txtbxTablero.Multiline = true;
            this.txtbxTablero.Name = "txtbxTablero";
            this.txtbxTablero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxTablero.Size = new System.Drawing.Size(276, 206);
            this.txtbxTablero.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "La Liebre y la Tortuga";
            // 
            // btnComenzar
            // 
            this.btnComenzar.AutoSize = true;
            this.btnComenzar.Location = new System.Drawing.Point(207, 67);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(107, 34);
            this.btnComenzar.TabIndex = 9;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxGanador);
            this.Controls.Add(this.txtbxTablero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxGanador;
        private System.Windows.Forms.TextBox txtbxTablero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComenzar;
    }
}

