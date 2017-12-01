using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers
{
    class PasswordDecoder
    {

        public static string Decode(string password)
        {
            throw new NotImplementedException();
        }

        public static string Decode(string password, string algorithm)
        {
            throw new NotImplementedException();
        }

        private static string DecodeInternal(string password, string algorithm)
        {
            string DecodedPassword = string.Empty;

            switch (algorithm)
            {
                case "SHA256":
                    DecodedPassword = DecodeSHA256(password);
                    break;
                case "SHA384":
                    DecodedPassword = DecodeSHA384(password);
                    break;
                case "SHA512":
                    DecodedPassword = DecodeSHA512(password);
                    break;
                case "AES":
                    DecodedPassword = DecodeAES(password);
                    break;
            }

            return DecodedPassword;
        }

        private static string DecodeSHA256(string password)
        {
            throw new NotImplementedException();
        }

        private static string DecodeSHA384(string password)
        {
            throw new NotImplementedException();
        }

        private static string DecodeSHA512(string password)
        {
            throw new NotImplementedException();
        }

        private static string DecodeAES(string password)
        {
            throw new NotImplementedException();
        }
    }
}
