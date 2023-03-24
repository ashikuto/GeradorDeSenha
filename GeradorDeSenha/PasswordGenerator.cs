using System.Security.Cryptography;
using System.Text;

namespace GeradorDeSenha
{
    public static class PasswordGenerator
    {
        private const string PasswordChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+-*/!@#$%¨&*0123456789";

        public static string GeneratePassword(int length, int passwordLength)
        {

            using (var rng = new RNGCryptoServiceProvider())
            {
                // gerando a senha
                var passwordBuilder = new StringBuilder();
                var passwordCharsLength = PasswordChars.Length;
                var buffer = new byte[sizeof(int)];
                for (int i = 0; i < passwordLength; i++)
                {
                    rng.GetBytes(buffer);
                    var randomIndex = BitConverter.ToInt32(buffer, 0);
                    var randomChar = PasswordChars[Math.Abs(randomIndex % passwordCharsLength)];
                    passwordBuilder.Append(randomChar);
                }
                return passwordBuilder.ToString();
            }

        }
    }
}
