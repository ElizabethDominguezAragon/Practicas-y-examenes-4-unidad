namespace _2_Arreglos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Areglo1 = new System.Windows.Forms.ListBox();
            this.Areglo2 = new System.Windows.Forms.ListBox();
            this.Areglo3 = new System.Windows.Forms.ListBox();
            this.Generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Areglo1
            // 
            this.Areglo1.FormattingEnabled = true;
            this.Areglo1.ItemHeight = 22;
            this.Areglo1.Location = new System.Drawing.Point(72, 54);
            this.Areglo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Areglo1.Name = "Areglo1";
            this.Areglo1.Size = new System.Drawing.Size(116, 224);
            this.Areglo1.TabIndex = 0;
            // 
            // Areglo2
            // 
            this.Areglo2.FormattingEnabled = true;
            this.Areglo2.ItemHeight = 22;
            this.Areglo2.Location = new System.Drawing.Point(225, 54);
            this.Areglo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Areglo2.Name = "Areglo2";
            this.Areglo2.Size = new System.Drawing.Size(116, 224);
            this.Areglo2.TabIndex = 1;
            // 
            // Areglo3
            // 
            this.Areglo3.FormattingEnabled = true;
            this.Areglo3.ItemHeight = 22;
            this.Areglo3.Location = new System.Drawing.Point(384, 54);
            this.Areglo3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Areglo3.Name = "Areglo3";
            this.Areglo3.Size = new System.Drawing.Size(116, 224);
            this.Areglo3.TabIndex = 2;
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(225, 325);
            this.Generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(118, 39);
            this.Generar.TabIndex = 3;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.Areglo3);
            this.Controls.Add(this.Areglo2);
            this.Controls.Add(this.Areglo1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Suma de Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Areglo1;
        private System.Windows.Forms.ListBox Areglo2;
        private System.Windows.Forms.ListBox Areglo3;
        private System.Windows.Forms.Button Generar;
    }
}

