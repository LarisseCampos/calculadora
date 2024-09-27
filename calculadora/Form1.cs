using System.Linq.Expressions;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    btnZero.PerformClick();
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    btnUm.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    btnDois.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    btnTres.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    btnQuatro.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    btnCinco.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    btnSeis.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    btnSete.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    btnOito.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    btnNove.PerformClick();
                    break;
                case Keys.Add:
                    btnAdicao.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSubtracao.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplicacao.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivisao.PerformClick();
                    break;
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                case Keys.Decimal:
                    btnVirgula.PerformClick();
                    break;
                case Keys.Back:
                    btnLimpar.PerformClick();
                    break;
            }
        }

        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada {  get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }   
        


        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text); 
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "X";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains (","))
                txtResultado.Text += ",";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
    }
}
