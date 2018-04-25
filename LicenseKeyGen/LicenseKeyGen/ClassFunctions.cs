using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKeyGen
{
    class ClassFunctions
    {

        public static string GenerateLicKeys()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[9];
            var random = new Random();

            for (int i = 0; i < 9; i++)
            {
                if (i == 4)
                {
                    stringChars[i] = '-';
                    continue;
                }
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new string(stringChars);
            return finalString;
        }

    }
}
