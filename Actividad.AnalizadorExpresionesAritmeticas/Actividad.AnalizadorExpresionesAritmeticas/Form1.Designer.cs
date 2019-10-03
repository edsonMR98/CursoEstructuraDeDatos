namespace Actividad.AnalizadorExpresionesAritmeticas
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
            this.txtBxExpresion = new System.Windows.Forms.TextBox();
            this.txtBxTabla = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxExpresion
            // 
            this.txtBxExpresion.Location = new System.Drawing.Point(12, 22);
            this.txtBxExpresion.Name = "txtBxExpresion";
            this.txtBxExpresion.Size = new System.Drawing.Size(326, 29);
            this.txtBxExpresion.TabIndex = 0;
            // 
            // txtBxTabla
            // 
            this.txtBxTabla.Location = new System.Drawing.Point(12, 69);
            this.txtBxTabla.Multiline = true;
            this.txtBxTabla.Name = "txtBxTabla";
            this.txtBxTabla.ReadOnly = true;
            this.txtBxTabla.Size = new System.Drawing.Size(420, 72);
            this.txtBxTabla.TabIndex = 3;
            this.txtBxTabla.TabStop = false;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.AutoSize = true;
            this.btnAnalizar.Location = new System.Drawing.Point(344, 20);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(88, 34);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 155);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtBxTabla);
            this.Controls.Add(this.txtBxExpresion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Analizador de Expresiones Aritmeticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxExpresion;
        private System.Windows.Forms.TextBox txtBxTabla;
        private System.Windows.Forms.Button btnAnalizar;
    }
}

