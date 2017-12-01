using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers
{
    class PasswordEncoder
    {

        public static string Encode(string password)
        {
            string encryptedPassword = EncodeInternal(password);
            return encryptedPassword;
        }

        public static string Encode(string password, string algorithm)
        {
            string encryptedPassword = EncodeInternal(password, algorithm);
            return encryptedPassword;
        }

        private static string EncodeInternal(string password, string algorithm = "SHA512")
        {
            string encryptedPassword = string.Empty;

            switch(algorithm)
            {
                case "SHA256":
                    encryptedPassword = EncodeSHA256(password);
                    break;
                case "SHA384":
                    encryptedPassword = EncodeSHA384(password);
                    break;
                case "SHA512":
                    encryptedPassword = EncodeSHA512(password);
                    break;
            }

            return encryptedPassword;
        }

        private static string EncodeSHA256(string password)
        {
            string encryptedPassword = string.Empty;

            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword).ToString();

            return encryptedPassword;
        }

        private static string EncodeSHA384(string password)
        {
            string encryptedPassword = string.Empty;

            SHA384CryptoServiceProvider provider = new SHA384CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword).ToString();

            return encryptedPassword;
        }

        private static string EncodeSHA512(string password)
        {
            string encryptedPassword = string.Empty;

            SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword).ToString();

            return encryptedPassword;
        }
    }
}
