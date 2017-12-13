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

        //public static byte[] Encode(string password)
        //{
        //    byte[] encryptedPassword = EncodeInternal(password);
        //    return encryptedPassword;
        //}

        private static string EncodeInternal(string password)
        {
            return EncodeSHA512(password);

            //switch (algorithm)
            //{
            //    case "SHA256":
            //        return EncodeSHA256(password);
            //    case "SHA384":
            //        return EncodeSHA384(password);
                
            //    default:
            //        return null;
            //}
        }

        private static string EncodeSHA256(string password)
        {
            byte[] encryptedPassword;

            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword);

            string result = System.Text.Encoding.Unicode.GetString(encodedPassword);

            return result;
        }

        private static string EncodeSHA384(string password)
        {
            byte[] encryptedPassword;

            SHA384CryptoServiceProvider provider = new SHA384CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword);

            string result = System.Text.Encoding.Unicode.GetString(encodedPassword);

            return result;
        }

        private static string EncodeSHA512(string password)
        {
            byte[] encryptedPassword;

            SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider();
            UnicodeEncoding encoding = new UnicodeEncoding();

            byte[] encodedPassword = encoding.GetBytes(password);

            encryptedPassword = provider.ComputeHash(encodedPassword);

            string result = System.Text.Encoding.Unicode.GetString(encodedPassword);

            return result;
        }
    }
}
