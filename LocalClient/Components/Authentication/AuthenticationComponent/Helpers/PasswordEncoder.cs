using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers
{
    class PasswordEncoder
    {

        public static string Encode(string password)
        {
            throw new NotImplementedException();
        }

        public static string Encode(string password, string algorithm)
        {
            throw new NotImplementedException();
        }

        private static string EncodeInternal(string password, string algorithm)
        {
            string encodedPassword = string.Empty;

            switch(algorithm)
            {
                case "SHA256":
                    encodedPassword = EncodeSHA256(password);
                    break;
                case "SHA384":
                    encodedPassword = EncodeSHA384(password);
                    break;
                case "SHA512":
                    encodedPassword = EncodeSHA512(password);
                    break;
                case "AES":
                    encodedPassword = EncodeAES(password);
                    break;
            }

            return encodedPassword;
        }

        private static string EncodeSHA256(string password)
        {
            throw new NotImplementedException();
        }

        private static string EncodeSHA384(string password)
        {
            throw new NotImplementedException();
        }

        private static string EncodeSHA512(string password)
        {
            throw new NotImplementedException();
        }

        private static string EncodeAES(string password)
        {
            throw new NotImplementedException();
        }
    }
}
