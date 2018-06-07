using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptLibrary
{
    public interface ICryptService
    {
        string Crypt(string text,string key);
        string Decrypt(string text, string key);
    }
}
