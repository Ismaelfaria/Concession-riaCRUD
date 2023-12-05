namespace ConcessionáriaAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.novosVeiculos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // novosVeiculos
            // 
            this.novosVeiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novosVeiculos.ForeColor = System.Drawing.Color.Black;
            this.novosVeiculos.Location = new System.Drawing.Point(197, 286);
            this.novosVeiculos.Name = "novosVeiculos";
            this.novosVeiculos.Size = new System.Drawing.Size(197, 57);
            this.novosVeiculos.TabIndex = 0;
            this.novosVeiculos.Text = "Novos Veiculos";
            this.novosVeiculos.UseVisualStyleBackColor = true;
            this.novosVeiculos.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(197, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.novosVeiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button novosVeiculos;
        private System.Windows.Forms.Button button1;
    }
}

