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
            this.SuspendLayout();
            // 
            // listCarro
            // 
            this.listCarro.HideSelection = false;
            this.listCarro.Location = new System.Drawing.Point(12, 12);
            this.listCarro.MultiSelect = false;
            this.listCarro.Name = "listCarro";
            this.listCarro.Size = new System.Drawing.Size(513, 250);
            this.listCarro.TabIndex = 0;
            this.listCarro.UseCompatibleStateImageBehavior = false;
            this.listCarro.SelectedIndexChanged += new System.EventHandler(this.listCarro_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(234, 281);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 22);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Deletar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 310);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listCarro);
            this.Name = "Registros";
            this.Text = "Registros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCarro;
        private System.Windows.Forms.Button Delete;
    }
}