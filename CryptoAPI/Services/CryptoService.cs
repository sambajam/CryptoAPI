
// Test - Git



using System;
using System.Linq;

namespace CryptoAPI.Services
{
    public class CryptoService
    {
        private const int Shift = 3;

        public string Encrypt(string input)
        {
            return new string(input.Select(c => (char)(c + Shift)).ToArray());
        }

        public string Decrypt(string input)
        {
            return new string(input.Select(c => (char)(c - Shift)).ToArray());
        }
    }
}
