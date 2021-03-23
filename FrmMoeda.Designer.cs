
namespace CircodeApps2
{
    partial class FrmMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoeda));
            this.BtnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReais = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblDolar = new System.Windows.Forms.Label();
            this.LblEuro = new System.Windows.Forms.Label();
            this.LblFranco = new System.Windows.Forms.Label();
            this.LblPesoMexicano = new System.Windows.Forms.Label();
            this.LblMostrarDólar = new System.Windows.Forms.Label();
            this.LblMostarEuro = new System.Windows.Forms.Label();
            this.LblMostarFranco = new System.Windows.Forms.Label();
            this.LblMostrarPesoMexicano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConverter
            // 
            this.BtnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverter.Location = new System.Drawing.Point(250, 24);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(89, 36);
            this.BtnConverter.TabIndex = 0;
            this.BtnConverter.Text = "Converter";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reais (R$)";
            // 
            // TxtReais
            // 
            this.TxtReais.Location = new System.Drawing.Point(31, 40);
            this.TxtReais.Name = "TxtReais";
            this.TxtReais.Size = new System.Drawing.Size(100, 20);
            this.TxtReais.TabIndex = 2;
            this.TxtReais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReais_KeyPress);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(250, 86);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(89, 34);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblDolar
            // 
            this.LblDolar.AutoSize = true;
            this.LblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDolar.Location = new System.Drawing.Point(19, 161);
            this.LblDolar.Name = "LblDolar";
            this.LblDolar.Size = new System.Drawing.Size(37, 13);
            this.LblDolar.TabIndex = 4;
            this.LblDolar.Text = "Dólar";
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEuro.Location = new System.Drawing.Point(164, 161);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(33, 13);
            this.LblEuro.TabIndex = 5;
            this.LblEuro.Text = "Euro";
            // 
            // LblFranco
            // 
            this.LblFranco.AutoSize = true;
            this.LblFranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFranco.Location = new System.Drawing.Point(19, 228);
            this.LblFranco.Name = "LblFranco";
            this.LblFranco.Size = new System.Drawing.Size(46, 13);
            this.LblFranco.TabIndex = 6;
            this.LblFranco.Text = "Franco";
            // 
            // LblPesoMexicano
            // 
            this.LblPesoMexicano.AutoSize = true;
            this.LblPesoMexicano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPesoMexicano.Location = new System.Drawing.Point(164, 228);
            this.LblPesoMexicano.Name = "LblPesoMexicano";
            this.LblPesoMexicano.Size = new System.Drawing.Size(93, 13);
            this.LblPesoMexicano.TabIndex = 7;
            this.LblPesoMexicano.Text = "Peso Mexicano";
            // 
            // LblMostrarDólar
            // 
            this.LblMostrarDólar.AutoSize = true;
            this.LblMostrarDólar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarDólar.Location = new System.Drawing.Point(28, 191);
            this.LblMostrarDólar.Name = "LblMostrarDólar";
            this.LblMostrarDólar.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarDólar.TabIndex = 12;
            // 
            // LblMostarEuro
            // 
            this.LblMostarEuro.AutoSize = true;
            this.LblMostarEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostarEuro.Location = new System.Drawing.Point(176, 191);
            this.LblMostarEuro.Name = "LblMostarEuro";
            this.LblMostarEuro.Size = new System.Drawing.Size(0, 16);
            this.LblMostarEuro.TabIndex = 13;
            // 
            // LblMostarFranco
            // 
            this.LblMostarFranco.AutoSize = true;
            this.LblMostarFranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostarFranco.Location = new System.Drawing.Point(28, 257);
            this.LblMostarFranco.Name = "LblMostarFranco";
            this.LblMostarFranco.Size = new System.Drawing.Size(0, 16);
            this.LblMostarFranco.TabIndex = 14;
            // 
            // LblMostrarPesoMexicano
            // 
            this.LblMostrarPesoMexicano.AutoSize = true;
            this.LblMostrarPesoMexicano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarPesoMexicano.Location = new System.Drawing.Point(176, 257);
            this.LblMostrarPesoMexicano.Name = "LblMostrarPesoMexicano";
            this.LblMostrarPesoMexicano.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarPesoMexicano.TabIndex = 15;
            // 
            // FrmMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 363);
            this.Controls.Add(this.LblMostrarPesoMexicano);
            this.Controls.Add(this.LblMostarFranco);
            this.Controls.Add(this.LblMostarEuro);
            this.Controls.Add(this.LblMostrarDólar);
            this.Controls.Add(this.LblPesoMexicano);
            this.Controls.Add(this.LblFranco);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.LblDolar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtReais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coversor de Moedas";
            this.Load += new System.EventHandler(this.FrmMoeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReais;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblDolar;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.Label LblFranco;
        private System.Windows.Forms.Label LblPesoMexicano;
        private System.Windows.Forms.Label LblMostrarDólar;
        private System.Windows.Forms.Label LblMostarEuro;
        private System.Windows.Forms.Label LblMostarFranco;
        private System.Windows.Forms.Label LblMostrarPesoMexicano;
    }
}