﻿namespace CircodeApps2
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnSair = new System.Windows.Forms.Button();
            this.PicBIMC = new System.Windows.Forms.PictureBox();
            this.LblIMC = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.PicBData = new System.Windows.Forms.PictureBox();
            this.LblViagem = new System.Windows.Forms.Label();
            this.PicBViagem = new System.Windows.Forms.PictureBox();
            this.LblEmprestimo = new System.Windows.Forms.Label();
            this.PicBEmprestimo = new System.Windows.Forms.PictureBox();
            this.LblMoeda = new System.Windows.Forms.Label();
            this.PicBMoeda = new System.Windows.Forms.PictureBox();
            this.LblMegaSena = new System.Windows.Forms.Label();
            this.PicBMega = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBDepreciacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBMega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBDepreciacao)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSair.Location = new System.Drawing.Point(652, 406);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(151, 62);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PicBIMC
            // 
            this.PicBIMC.Image = global::CircodeApps2.Properties.Resources.imc;
            this.PicBIMC.Location = new System.Drawing.Point(13, 13);
            this.PicBIMC.Name = "PicBIMC";
            this.PicBIMC.Size = new System.Drawing.Size(152, 138);
            this.PicBIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBIMC.TabIndex = 1;
            this.PicBIMC.TabStop = false;
            this.PicBIMC.Click += new System.EventHandler(this.PicBIMC_Click);
            // 
            // LblIMC
            // 
            this.LblIMC.AutoSize = true;
            this.LblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIMC.Location = new System.Drawing.Point(22, 154);
            this.LblIMC.Name = "LblIMC";
            this.LblIMC.Size = new System.Drawing.Size(130, 20);
            this.LblIMC.TabIndex = 2;
            this.LblIMC.Text = "Cálculo do IMC";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(213, 154);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(137, 20);
            this.LblData.TabIndex = 4;
            this.LblData.Text = "Cálculo da Data";
            // 
            // PicBData
            // 
            this.PicBData.Image = global::CircodeApps2.Properties.Resources.calendario;
            this.PicBData.Location = new System.Drawing.Point(204, 13);
            this.PicBData.Name = "PicBData";
            this.PicBData.Size = new System.Drawing.Size(152, 138);
            this.PicBData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBData.TabIndex = 3;
            this.PicBData.TabStop = false;
            this.PicBData.Click += new System.EventHandler(this.PicBData_Click);
            // 
            // LblViagem
            // 
            this.LblViagem.AutoSize = true;
            this.LblViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViagem.Location = new System.Drawing.Point(397, 155);
            this.LblViagem.Name = "LblViagem";
            this.LblViagem.Size = new System.Drawing.Size(158, 20);
            this.LblViagem.TabIndex = 6;
            this.LblViagem.Text = "Cálculo da Viagem";
            // 
            // PicBViagem
            // 
            this.PicBViagem.Image = global::CircodeApps2.Properties.Resources.viagem2;
            this.PicBViagem.Location = new System.Drawing.Point(403, 12);
            this.PicBViagem.Name = "PicBViagem";
            this.PicBViagem.Size = new System.Drawing.Size(152, 138);
            this.PicBViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBViagem.TabIndex = 5;
            this.PicBViagem.TabStop = false;
            this.PicBViagem.Click += new System.EventHandler(this.PicBViagem_Click);
            // 
            // LblEmprestimo
            // 
            this.LblEmprestimo.AutoSize = true;
            this.LblEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmprestimo.Location = new System.Drawing.Point(610, 155);
            this.LblEmprestimo.Name = "LblEmprestimo";
            this.LblEmprestimo.Size = new System.Drawing.Size(193, 20);
            this.LblEmprestimo.TabIndex = 8;
            this.LblEmprestimo.Text = "Cálculo de Empréstimo";
            // 
            // PicBEmprestimo
            // 
            this.PicBEmprestimo.Image = global::CircodeApps2.Properties.Resources.emprestimo;
            this.PicBEmprestimo.Location = new System.Drawing.Point(616, 12);
            this.PicBEmprestimo.Name = "PicBEmprestimo";
            this.PicBEmprestimo.Size = new System.Drawing.Size(152, 138);
            this.PicBEmprestimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBEmprestimo.TabIndex = 7;
            this.PicBEmprestimo.TabStop = false;
            this.PicBEmprestimo.Click += new System.EventHandler(this.PicBEmprestimo_Click);
            // 
            // LblMoeda
            // 
            this.LblMoeda.AutoSize = true;
            this.LblMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoeda.Location = new System.Drawing.Point(7, 353);
            this.LblMoeda.Name = "LblMoeda";
            this.LblMoeda.Size = new System.Drawing.Size(173, 20);
            this.LblMoeda.TabIndex = 10;
            this.LblMoeda.Text = "Coversor de Moedas";
            // 
            // PicBMoeda
            // 
            this.PicBMoeda.Image = global::CircodeApps2.Properties.Resources.moeda;
            this.PicBMoeda.Location = new System.Drawing.Point(13, 210);
            this.PicBMoeda.Name = "PicBMoeda";
            this.PicBMoeda.Size = new System.Drawing.Size(152, 138);
            this.PicBMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBMoeda.TabIndex = 9;
            this.PicBMoeda.TabStop = false;
            this.PicBMoeda.Click += new System.EventHandler(this.PicBMoeda_Click);
            // 
            // LblMegaSena
            // 
            this.LblMegaSena.AutoSize = true;
            this.LblMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMegaSena.Location = new System.Drawing.Point(213, 351);
            this.LblMegaSena.Name = "LblMegaSena";
            this.LblMegaSena.Size = new System.Drawing.Size(100, 20);
            this.LblMegaSena.TabIndex = 12;
            this.LblMegaSena.Text = "Mega Sena";
            // 
            // PicBMega
            // 
            this.PicBMega.Image = global::CircodeApps2.Properties.Resources.mega;
            this.PicBMega.Location = new System.Drawing.Point(198, 210);
            this.PicBMega.Name = "PicBMega";
            this.PicBMega.Size = new System.Drawing.Size(152, 138);
            this.PicBMega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBMega.TabIndex = 11;
            this.PicBMega.TabStop = false;
            this.PicBMega.Click += new System.EventHandler(this.PicBMega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Depreciação Veicular ";
            // 
            // PicBDepreciacao
            // 
            this.PicBDepreciacao.Image = global::CircodeApps2.Properties.Resources.Veiculo;
            this.PicBDepreciacao.Location = new System.Drawing.Point(403, 210);
            this.PicBDepreciacao.Name = "PicBDepreciacao";
            this.PicBDepreciacao.Size = new System.Drawing.Size(152, 138);
            this.PicBDepreciacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBDepreciacao.TabIndex = 13;
            this.PicBDepreciacao.TabStop = false;
            this.PicBDepreciacao.Click += new System.EventHandler(this.PicBDepreciacao_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(843, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBDepreciacao);
            this.Controls.Add(this.LblMegaSena);
            this.Controls.Add(this.PicBMega);
            this.Controls.Add(this.LblMoeda);
            this.Controls.Add(this.PicBMoeda);
            this.Controls.Add(this.LblEmprestimo);
            this.Controls.Add(this.PicBEmprestimo);
            this.Controls.Add(this.LblViagem);
            this.Controls.Add(this.PicBViagem);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.PicBData);
            this.Controls.Add(this.LblIMC);
            this.Controls.Add(this.PicBIMC);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.PicBIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBMega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBDepreciacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox PicBIMC;
        private System.Windows.Forms.Label LblIMC;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.PictureBox PicBData;
        private System.Windows.Forms.Label LblViagem;
        private System.Windows.Forms.PictureBox PicBViagem;
        private System.Windows.Forms.Label LblEmprestimo;
        private System.Windows.Forms.PictureBox PicBEmprestimo;
        private System.Windows.Forms.Label LblMoeda;
        private System.Windows.Forms.PictureBox PicBMoeda;
        private System.Windows.Forms.Label LblMegaSena;
        private System.Windows.Forms.PictureBox PicBMega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBDepreciacao;
    }
}

