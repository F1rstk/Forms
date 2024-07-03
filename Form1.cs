namespace Ex._3
{
    public partial class frmProjeto2 : Form
    {
        public frmProjeto2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Criação de variaveis.
            String nome;
            Double Valor;
            Double Dolar;
            Double Resultado;

            //Atribuições Valores das caixas de texto para variavies.
            nome = textNomeProduto.Text;
            Valor = double.Parse(textValorProduto.Text);
            Dolar = double.Parse(textContacao.Text);

            Resultado = Dolar*Valor;

            string ValorFormatdo = string.Format("{0:C}", Resultado);

            lblMesagem.Text = "Seu Produto " + nome + " O Valor em reais é " + ValorFormatdo;



        }
    }
}