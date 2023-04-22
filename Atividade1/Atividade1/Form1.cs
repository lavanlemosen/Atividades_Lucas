
namespace Atividade1;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    Funcoes fun = new Funcoes();


    private void LarguraBox_Leave(object sender, EventArgs e)
    {
        fun.Sair_Vazio(LarguraBox, "Digite a Largura");
    }

    private void LarguraBox_Enter(object sender, EventArgs e)
    {
        fun.Entrar_Algo(LarguraBox, "Digite a Largura");
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
        fun.Entrar_Algo(ComprimentoBox, "Digite o Comprimento");
    }

    private void ComprimentoBox_Leave(object sender, EventArgs e)
    {
        fun.Sair_Vazio(ComprimentoBox, "Digite o Comprimento");
    }

    private void LarguraBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        fun.Confere_numeros(e, LarguraBox);
    }

    private void Bt_Calcular_Click(object sender, EventArgs e)
    {
        try
        {
            double Comprimento, Largura, Area;
            Comprimento = Convert.ToDouble(ComprimentoBox.Text);
            Largura = Convert.ToDouble(LarguraBox.Text);
            if (Comprimento == 0 && Comprimento == 0)
            {
                MessageBox.Show("Seu comprimento e largura não podem ser 0", "Imobilis",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Comprimento == 0)
            {

                MessageBox.Show("Seu comprimento  não pode ser 0", "Imobilis",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (Largura == 0)
            {

                MessageBox.Show("Sua largura não pode ser 0", "Imobilis",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Area = Largura * Comprimento;
                MessageBox.Show($"Sua area é igual {Area}", "Imobilis", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        catch (FormatException)
        {
            MessageBox.Show("Algum campo não foi devidamente preenchido", "Imobilis",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (OverflowException)
        {
            MessageBox.Show("Algum de seus campos apresentar um valor grande demais para o calculo", "Imobilis",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void ComprimentoBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        fun.Confere_numeros(e, ComprimentoBox);
    }
}