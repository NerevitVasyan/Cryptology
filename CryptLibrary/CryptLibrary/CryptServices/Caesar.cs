using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptLibrary
{
    public class Caesar : ICryptService
    {
        private char CryptChar(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = (char.IsUpper(ch)) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }


        public string Crypt(string text, string key)
        {
            string Cryptedtext = "";
            int K = Convert.ToInt32(key);

            foreach(char s in text)
            {
                Cryptedtext += CryptChar(s, K);
            }

            return Cryptedtext;
        }

        public string Decrypt(string text, string key)
        {

            return Crypt(text, (26 - Convert.ToInt32(key)).ToString());
        }
    }
}
