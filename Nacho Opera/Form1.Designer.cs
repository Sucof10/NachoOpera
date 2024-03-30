namespace Nacho_Opera
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
            this.button1 = new System.Windows.Forms.Button();
            this.IN = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Hasta = new System.Windows.Forms.TextBox();
            this.Limite = new System.Windows.Forms.Label();
            this.RESULTADO = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IN
            // 
            this.IN.AutoSize = true;
            this.IN.Location = new System.Drawing.Point(33, 101);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(41, 13);
            this.IN.TabIndex = 1;
            this.IN.Text = "TABLA";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(36, 134);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 20);
            this.Numero.TabIndex = 2;
            // 
            // Hasta
            // 
            this.Hasta.Location = new System.Drawing.Point(36, 228);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(100, 20);
            this.Hasta.TabIndex = 3;
            // 
            // Limite
            // 
            this.Limite.AutoSize = true;
            this.Limite.Location = new System.Drawing.Point(33, 194);
            this.Limite.Name = "Limite";
            this.Limite.Size = new System.Drawing.Size(42, 13);
            this.Limite.TabIndex = 4;
            this.Limite.Text = "LIMITE";
            // 
            // RESULTADO
            // 
            this.RESULTADO.FormattingEnabled = true;
            this.RESULTADO.Location = new System.Drawing.Point(232, 60);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(215, 251);
            this.RESULTADO.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.Limite);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.IN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ingrese Numero";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IN;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Hasta;
        private System.Windows.Forms.Label Limite;
        private System.Windows.Forms.ListBox RESULTADO;
    }
}

