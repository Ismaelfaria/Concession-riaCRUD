namespace ConcessionáriaAPI
{
    partial class Registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCarro = new System.Windows.Forms.ListView();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCarro
            // 
            this.listCarro.HideSelection = false;
            this.listCarro.Location = new System.Drawing.Point(45, 55);
            this.listCarro.MultiSelect = false;
            this.listCarro.Name = "listCarro";
            this.listCarro.Size = new System.Drawing.Size(364, 216);
            this.listCarro.TabIndex = 0;
            this.listCarro.UseCompatibleStateImageBehavior = false;
            this.listCarro.SelectedIndexChanged += new System.EventHandler(this.listCarro_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(426, 55);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 216);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Deletar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listCarro);
            this.Name = "Registros";
            this.Text = "Registros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCarro;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
    }
}