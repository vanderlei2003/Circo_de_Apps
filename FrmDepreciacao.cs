using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps2
{
    public partial class FrmDepreciacao : Form
    {
        public FrmDepreciacao()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtValorVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void FrmDepreciacao_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtValorVeiculo;
            TxtValorVeiculo.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double ValorVeiculo, AnoVeiculo, DepreciacaoAnual, DepreciacaoMensal, DifAno, DepDifAno, ValorAtual;
            ValorVeiculo = Convert.ToDouble(TxtValorVeiculo.Text);
            AnoVeiculo = Convert.ToDouble(TxtAno.Text);
            DepreciacaoAnual = ValorVeiculo / 5;
            DepreciacaoMensal = DepreciacaoAnual / 12;
            DifAno = DateTime.Now.Year - AnoVeiculo;
            DepDifAno = DepreciacaoAnual * DifAno;
            ValorAtual = ValorVeiculo - DepDifAno;
            LblMostrarDepreciacaoAnual.Text = "R$" + DepreciacaoAnual.ToString("N2");
            LblMostrarDepreciacaoMensal.Text = "R$" + DepreciacaoMensal.ToString("N2");
            LblMostrarValorAtual.Text = "R$" + ValorAtual.ToString("N2");
            TxtValorVeiculo.Text = "";
            TxtAno.Text = "";
            this.ActiveControl = TxtValorVeiculo;
            TxtValorVeiculo.Focus();
        }

   
    }
}
