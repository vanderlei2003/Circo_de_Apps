
namespace CircodeApps2
{
    partial class FrmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimo));
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtJuros = new System.Windows.Forms.TextBox();
            this.GrbRespostas = new System.Windows.Forms.GroupBox();
            this.TxtJurosPagos = new System.Windows.Forms.TextBox();
            this.TxtPagamentoMensal = new System.Windows.Forms.TextBox();
            this.LblJurosPagos = new System.Windows.Forms.Label();
            this.LblMensal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblJuros = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblPrazo = new System.Windows.Forms.Label();
            this.TxtPrazo = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.GrbRespostas.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(30, 31);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(118, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valor do Empéstimo";
            // 
            // TxtJuros
            // 
            this.TxtJuros.Location = new System.Drawing.Point(33, 111);
            this.TxtJuros.Name = "TxtJuros";
            this.TxtJuros.Size = new System.Drawing.Size(115, 20);
            this.TxtJuros.TabIndex = 1;
            this.TxtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJuros_KeyPress);
            // 
            // GrbRespostas
            // 
            this.GrbRespostas.Controls.Add(this.TxtJurosPagos);
            this.GrbRespostas.Controls.Add(this.TxtPagamentoMensal);
            this.GrbRespostas.Controls.Add(this.LblJurosPagos);
            this.GrbRespostas.Controls.Add(this.LblMensal);
            this.GrbRespostas.Controls.Add(this.TxtTotal);
            this.GrbRespostas.Controls.Add(this.LblTotal);
            this.GrbRespostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbRespostas.Location = new System.Drawing.Point(204, 31);
            this.GrbRespostas.Name = "GrbRespostas";
            this.GrbRespostas.Size = new System.Drawing.Size(200, 245);
            this.GrbRespostas.TabIndex = 2;
            this.GrbRespostas.TabStop = false;
            this.GrbRespostas.Text = "Demonstrativo";
            // 
            // TxtJurosPagos
            // 
            this.TxtJurosPagos.Location = new System.Drawing.Point(18, 196);
            this.TxtJurosPagos.Name = "TxtJurosPagos";
            this.TxtJurosPagos.Size = new System.Drawing.Size(124, 20);
            this.TxtJurosPagos.TabIndex = 13;
            // 
            // TxtPagamentoMensal
            // 
            this.TxtPagamentoMensal.Location = new System.Drawing.Point(18, 52);
            this.TxtPagamentoMensal.Name = "TxtPagamentoMensal";
            this.TxtPagamentoMensal.Size = new System.Drawing.Size(124, 20);
            this.TxtPagamentoMensal.TabIndex = 14;
            // 
            // LblJurosPagos
            // 
            this.LblJurosPagos.AutoSize = true;
            this.LblJurosPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJurosPagos.Location = new System.Drawing.Point(15, 180);
            this.LblJurosPagos.Name = "LblJurosPagos";
            this.LblJurosPagos.Size = new System.Drawing.Size(76, 13);
            this.LblJurosPagos.TabIndex = 12;
            this.LblJurosPagos.Text = "Juros Pagos";
            // 
            // LblMensal
            // 
            this.LblMensal.AutoSize = true;
            this.LblMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensal.Location = new System.Drawing.Point(15, 36);
            this.LblMensal.Name = "LblMensal";
            this.LblMensal.Size = new System.Drawing.Size(114, 13);
            this.LblMensal.TabIndex = 9;
            this.LblMensal.Text = "Pagamento Mensal";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(18, 119);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(124, 20);
            this.TxtTotal.TabIndex = 10;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(15, 103);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(69, 13);
            this.LblTotal.TabIndex = 11;
            this.LblTotal.Text = "Total Pago";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(493, 31);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblJuros
            // 
            this.LblJuros.AutoSize = true;
            this.LblJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJuros.Location = new System.Drawing.Point(30, 95);
            this.LblJuros.Name = "LblJuros";
            this.LblJuros.Size = new System.Drawing.Size(58, 13);
            this.LblJuros.TabIndex = 4;
            this.LblJuros.Text = "Juros (%)";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(493, 95);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(100, 23);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblPrazo
            // 
            this.LblPrazo.AutoSize = true;
            this.LblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrazo.Location = new System.Drawing.Point(30, 172);
            this.LblPrazo.Name = "LblPrazo";
            this.LblPrazo.Size = new System.Drawing.Size(79, 13);
            this.LblPrazo.TabIndex = 6;
            this.LblPrazo.Text = "Prazo (Anos)";
            // 
            // TxtPrazo
            // 
            this.TxtPrazo.Location = new System.Drawing.Point(33, 188);
            this.TxtPrazo.Name = "TxtPrazo";
            this.TxtPrazo.Size = new System.Drawing.Size(115, 20);
            this.TxtPrazo.TabIndex = 7;
            this.TxtPrazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrazo_KeyPress);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(33, 48);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(115, 20);
            this.TxtValor.TabIndex = 8;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 339);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtPrazo);
            this.Controls.Add(this.LblPrazo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblJuros);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.GrbRespostas);
            this.Controls.Add(this.TxtJuros);
            this.Controls.Add(this.LblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Empréstimo";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.GrbRespostas.ResumeLayout(false);
            this.GrbRespostas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtJuros;
        private System.Windows.Forms.GroupBox GrbRespostas;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblJuros;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblPrazo;
        private System.Windows.Forms.TextBox TxtPrazo;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtPagamentoMensal;
        private System.Windows.Forms.TextBox TxtJurosPagos;
        private System.Windows.Forms.Label LblJurosPagos;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblMensal;
    }
}