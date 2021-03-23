
namespace CircodeApps2
{
    partial class FrmMega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMega));
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblNumerosGerados = new System.Windows.Forms.Label();
            this.ListBNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGerar
            // 
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.Location = new System.Drawing.Point(278, 27);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(87, 30);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(278, 84);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(87, 29);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblNumerosGerados
            // 
            this.LblNumerosGerados.AutoSize = true;
            this.LblNumerosGerados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumerosGerados.Location = new System.Drawing.Point(12, 27);
            this.LblNumerosGerados.Name = "LblNumerosGerados";
            this.LblNumerosGerados.Size = new System.Drawing.Size(107, 13);
            this.LblNumerosGerados.TabIndex = 2;
            this.LblNumerosGerados.Text = "Numeros Gerados";
            // 
            // ListBNumeros
            // 
            this.ListBNumeros.FormattingEnabled = true;
            this.ListBNumeros.Location = new System.Drawing.Point(15, 57);
            this.ListBNumeros.Name = "ListBNumeros";
            this.ListBNumeros.Size = new System.Drawing.Size(183, 121);
            this.ListBNumeros.TabIndex = 3;
            // 
            // FrmMega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 217);
            this.Controls.Add(this.ListBNumeros);
            this.Controls.Add(this.LblNumerosGerados);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Apostas MegaSena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblNumerosGerados;
        private System.Windows.Forms.ListBox ListBNumeros;
    }
}