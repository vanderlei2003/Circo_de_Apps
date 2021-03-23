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
    public partial class FrmMoeda : Form
    {
        public FrmMoeda()
        {
            InitializeComponent();
        }

        private void FrmMoeda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtReais;
            TxtReais.Focus();
        }

        private void TxtReais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            double Reais, Dolar, Euro, Franco, PesoMexicano;
            Reais = Convert.ToDouble(TxtReais.Text);
            Dolar = Reais / 5.23;
            Euro = Reais / 6.30;
            Franco = Reais / 5.84;
            PesoMexicano = Reais / 0.26;
            LblMostrarDólar.Text = Dolar.ToString("N2");
            LblMostarEuro.Text = Euro.ToString("N2");
            LblMostarFranco.Text = Franco.ToString("N2");
            LblMostrarPesoMexicano.Text = PesoMexicano.ToString("N2");
            TxtReais.Text = "";
            this.ActiveControl = TxtReais;
            TxtReais.Focus();
        }
    }
}
