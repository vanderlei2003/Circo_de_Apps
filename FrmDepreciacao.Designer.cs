
namespace CircodeApps2
{
    partial class FrmDepreciacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacao));
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblValorVeiculo = new System.Windows.Forms.Label();
            this.TxtValorVeiculo = new System.Windows.Forms.TextBox();
            this.LblDepreciacaoAnual = new System.Windows.Forms.Label();
            this.LblMostrarDepreciacaoAnual = new System.Windows.Forms.Label();
            this.LblDepreciacaoMensal = new System.Windows.Forms.Label();
            this.LblMostrarDepreciacaoMensal = new System.Windows.Forms.Label();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMostrarValorAtual = new System.Windows.Forms.Label();
            this.LblValorAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(317, 57);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(317, 128);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblValorVeiculo
            // 
            this.LblValorVeiculo.AutoSize = true;
            this.LblValorVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorVeiculo.Location = new System.Drawing.Point(12, 22);
            this.LblValorVeiculo.Name = "LblValorVeiculo";
            this.LblValorVeiculo.Size = new System.Drawing.Size(128, 13);
            this.LblValorVeiculo.TabIndex = 2;
            this.LblValorVeiculo.Text = "Valor do Veiculo 0Km";
            // 
            // TxtValorVeiculo
            // 
            this.TxtValorVeiculo.Location = new System.Drawing.Point(15, 48);
            this.TxtValorVeiculo.Name = "TxtValorVeiculo";
            this.TxtValorVeiculo.Size = new System.Drawing.Size(139, 20);
            this.TxtValorVeiculo.TabIndex = 3;
            this.TxtValorVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorVeiculo_KeyPress);
            // 
            // LblDepreciacaoAnual
            // 
            this.LblDepreciacaoAnual.AutoSize = true;
            this.LblDepreciacaoAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepreciacaoAnual.Location = new System.Drawing.Point(12, 174);
            this.LblDepreciacaoAnual.Name = "LblDepreciacaoAnual";
            this.LblDepreciacaoAnual.Size = new System.Drawing.Size(115, 13);
            this.LblDepreciacaoAnual.TabIndex = 4;
            this.LblDepreciacaoAnual.Text = "Depreciação Anual";
            // 
            // LblMostrarDepreciacaoAnual
            // 
            this.LblMostrarDepreciacaoAnual.AutoSize = true;
            this.LblMostrarDepreciacaoAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarDepreciacaoAnual.Location = new System.Drawing.Point(12, 204);
            this.LblMostrarDepreciacaoAnual.Name = "LblMostrarDepreciacaoAnual";
            this.LblMostrarDepreciacaoAnual.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarDepreciacaoAnual.TabIndex = 5;
            // 
            // LblDepreciacaoMensal
            // 
            this.LblDepreciacaoMensal.AutoSize = true;
            this.LblDepreciacaoMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepreciacaoMensal.Location = new System.Drawing.Point(12, 262);
            this.LblDepreciacaoMensal.Name = "LblDepreciacaoMensal";
            this.LblDepreciacaoMensal.Size = new System.Drawing.Size(123, 13);
            this.LblDepreciacaoMensal.TabIndex = 6;
            this.LblDepreciacaoMensal.Text = "Depreciação Mensal";
            // 
            // LblMostrarDepreciacaoMensal
            // 
            this.LblMostrarDepreciacaoMensal.AutoSize = true;
            this.LblMostrarDepreciacaoMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarDepreciacaoMensal.Location = new System.Drawing.Point(12, 299);
            this.LblMostrarDepreciacaoMensal.Name = "LblMostrarDepreciacaoMensal";
            this.LblMostrarDepreciacaoMensal.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarDepreciacaoMensal.TabIndex = 7;
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(15, 119);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(139, 20);
            this.TxtAno.TabIndex = 9;
            //this.TxtAno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAno.Location = new System.Drawing.Point(12, 93);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(95, 13);
            this.LblAno.TabIndex = 8;
            this.LblAno.Text = "Ano Do Veiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // LblMostrarValorAtual
            // 
            this.LblMostrarValorAtual.AutoSize = true;
            this.LblMostrarValorAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarValorAtual.Location = new System.Drawing.Point(12, 383);
            this.LblMostrarValorAtual.Name = "LblMostrarValorAtual";
            this.LblMostrarValorAtual.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarValorAtual.TabIndex = 13;
            // 
            // LblValorAtual
            // 
            this.LblValorAtual.AutoSize = true;
            this.LblValorAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorAtual.Location = new System.Drawing.Point(12, 346);
            this.LblValorAtual.Name = "LblValorAtual";
            this.LblValorAtual.Size = new System.Drawing.Size(133, 13);
            this.LblValorAtual.TabIndex = 12;
            this.LblValorAtual.Text = "Valor Atual do Veiculo";
            // 
            // FrmDepreciacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 421);
            this.Controls.Add(this.LblMostrarValorAtual);
            this.Controls.Add(this.LblValorAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.LblMostrarDepreciacaoMensal);
            this.Controls.Add(this.LblDepreciacaoMensal);
            this.Controls.Add(this.LblMostrarDepreciacaoAnual);
            this.Controls.Add(this.LblDepreciacaoAnual);
            this.Controls.Add(this.TxtValorVeiculo);
            this.Controls.Add(this.LblValorVeiculo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepreciacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciação Veicular";
            this.Load += new System.EventHandler(this.FrmDepreciacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblValorVeiculo;
        private System.Windows.Forms.TextBox TxtValorVeiculo;
        private System.Windows.Forms.Label LblDepreciacaoAnual;
        private System.Windows.Forms.Label LblMostrarDepreciacaoAnual;
        private System.Windows.Forms.Label LblDepreciacaoMensal;
        private System.Windows.Forms.Label LblMostrarDepreciacaoMensal;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMostrarValorAtual;
        private System.Windows.Forms.Label LblValorAtual;
    }
}