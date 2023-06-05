namespace MatrizPromedioColumna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LLenarMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LLenarMatriz
            // 
            this.LLenarMatriz.Location = new System.Drawing.Point(112, 65);
            this.LLenarMatriz.Name = "LLenarMatriz";
            this.LLenarMatriz.Size = new System.Drawing.Size(116, 23);
            this.LLenarMatriz.TabIndex = 1;
            this.LLenarMatriz.Text = "Generar Matriz";
            this.LLenarMatriz.UseVisualStyleBackColor = true;
            this.LLenarMatriz.Click += new System.EventHandler(this.LLenarMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 167);
            this.Controls.Add(this.LLenarMatriz);
            this.Name = "Form1";
            this.Text = "Promedio x filas";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LLenarMatriz;
        private DataGridView dataGridView1;
    }
}