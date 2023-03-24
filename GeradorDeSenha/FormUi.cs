using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeradorDeSenha
{
    public partial class FormUi : MetroFramework.Forms.MetroForm
    {
        private string password;

        public FormUi()
        {
            InitializeComponent();
        }
        public void salvar()
        {
            {
                // Conte�do da string
                string conteudo = password;

                // Cria o objeto SaveFileDialog
                SaveFileDialog salvarArquivo = new SaveFileDialog();
                salvarArquivo.Filter = "Arquivos de texto (*.txt)|*.txt";

                // Exibe a janela de di�logo para escolher o local de salvamento
                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                {
                    // Cria o arquivo de texto e grava a string no arquivo
                    using (StreamWriter sw = File.CreateText(salvarArquivo.FileName))
                    {
                        sw.Write(conteudo);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int passwordLength;
            if (!int.TryParse(txtPasswordLength.Text, out passwordLength) || passwordLength <= 0)
            {
                MessageBox.Show("Por favor, digite um comprimento de senha v�lido.");
                return;
            }

            password = PasswordGenerator.GeneratePassword(passwordLength, passwordLength);

            lblLastPassword.Text = password; // atualiza a Label com a �ltima senha gerada
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblLastPassword.Text = string.Empty; // limpa o texto da Label
            password = "";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("N�o h� nenhuma senha gerada para ser copiada!");
            }
            else
            {
                Clipboard.SetText(password);
                MessageBox.Show("Senha copiada com sucesso!");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("N�o h� nenhuma senha gerada para salvar!");
            }
            else
            {
                salvar();
            }

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este � um gerador de senha simples que permite que voc� crie senhas aleat�rias para uso em suas contas online. Para usar o programa, basta clicar no bot�o \"Gerar senha\", que ir� criar uma senha aleat�ria e poder� copi�-la para a �rea de transfer�ncia do seu computador.\r\n\r\nVoc� pode ajustar o comprimento da senha digitando o n�mero desejado na caixa \"Comprimento da senha\". A senha gerada ser� composta por letras mai�sculas e min�sculas, n�meros e s�mbolos, e ter� o comprimento especificado por voc�.\r\n\r\nUma vez que a senha � gerada, ela ser� exibida na caixa de mensagem. Voc� pode copiar e colar a senha em qualquer campo de senha que estiver usando. � importante lembrar de guardar a senha em um lugar seguro, como um gerenciador de senhas, para n�o esquec�-la.\r\n\r\nCaso voc� n�o esteja satisfeito com a senha gerada, basta clicar novamente no bot�o \"Gerar senha\" para criar uma nova senha aleat�ria. O programa � f�cil de usar e pode ajudar a garantir que suas contas online estejam protegidas com senhas fortes e exclusivas.");
        }

        private void �ndiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vers�o: 1.1");
        }

        private void sum�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�Kish2023 \n �cones criados por Dragon Icons - Flaticon \n https://www.flaticon.com/br/icones-gratis/produzir");
        }
    }

}
