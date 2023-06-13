namespace revisjon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
            lb_resposta.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            divisao divisao = new divisao();
            divisao.ShowDialog();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_valor1.Text);
            int b = Convert.ToInt32(tx_valor2.Text);
            int c = a / b;

            lb_resultado.Text = (c.ToString());


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rbt_a.Checked)
            {
                string sexo = rbt_a.Text;
                lb_resposta.Text = sexo;
            }
            else if (rbt_b.Checked)
            {
                string sexo = rbt_b.Text;
                lb_resposta.Text = sexo;
            }

        }
    }
}