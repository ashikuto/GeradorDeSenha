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
                // Conteúdo da string
                string conteudo = password;

                // Cria o objeto SaveFileDialog
                SaveFileDialog salvarArquivo = new SaveFileDialog();
                salvarArquivo.Filter = "Arquivos de texto (*.txt)|*.txt";

                // Exibe a janela de diálogo para escolher o local de salvamento
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
                MessageBox.Show("Por favor, digite um comprimento de senha válido.");
                return;
            }

            password = PasswordGenerator.GeneratePassword(passwordLength, passwordLength);

            lblLastPassword.Text = password; // atualiza a Label com a última senha gerada
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
                MessageBox.Show("Não há nenhuma senha gerada para ser copiada!");
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
                MessageBox.Show("Não há nenhuma senha gerada para salvar!");
            }
            else
            {
                salvar();
            }

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é um gerador de senha simples que permite que você crie senhas aleatórias para uso em suas contas online. Para usar o programa, basta clicar no botão \"Gerar senha\", que irá criar uma senha aleatória e poderá copiá-la para a área de transferência do seu computador.\r\n\r\nVocê pode ajustar o comprimento da senha digitando o número desejado na caixa \"Comprimento da senha\". A senha gerada será composta por letras maiúsculas e minúsculas, números e símbolos, e terá o comprimento especificado por você.\r\n\r\nUma vez que a senha é gerada, ela será exibida na caixa de mensagem. Você pode copiar e colar a senha em qualquer campo de senha que estiver usando. É importante lembrar de guardar a senha em um lugar seguro, como um gerenciador de senhas, para não esquecê-la.\r\n\r\nCaso você não esteja satisfeito com a senha gerada, basta clicar novamente no botão \"Gerar senha\" para criar uma nova senha aleatória. O programa é fácil de usar e pode ajudar a garantir que suas contas online estejam protegidas com senhas fortes e exclusivas.");
        }

        private void índiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão: 1.1");
        }

        private void sumárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("©Kish2023 \n Ícones criados por Dragon Icons - Flaticon \n https://www.flaticon.com/br/icones-gratis/produzir");
        }
    }

}
