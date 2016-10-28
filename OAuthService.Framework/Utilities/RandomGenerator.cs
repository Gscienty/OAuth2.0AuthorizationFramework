using System;
using System.Text;
using System.Security.Cryptography;

namespace OAuthService.Framework.Utilities
{
    internal static class RandomGenerator
    {
        private static char[] CharsMap = { 
            ' ', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', 
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?', 
            '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z', '{', '|', '}', '~' };
        private static byte[] GeneratorRandomBuffer(int length)
        {
            byte[] buff = new byte[length];
            RandomNumberGenerator.Create().GetBytes(buff);
            return buff;
        }

        internal static string GeneratorRandomVSCode(int length)
        {
            byte[] buff = GeneratorRandomBuffer(length);
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < length; i++) { builder.Append(CharsMap[buff[i] % 95]); }
            return builder.ToString();
        }

        internal static string GeneratorRandomNQCode(int length)
        {
            byte[] buff = GeneratorRandomBuffer(length);
            StringBuilder builder = new StringBuilder();
            Func<byte, int> convert = new Func<byte, int>(bt => bt % 95 == 0x00 || bt % 95 == 0x02 || bt % 95 == 0x3C ? 94 : bt % 95 );
            for(int i = 0; i < length; i++) { builder.Append(CharsMap[convert(buff[i])]); }
            return builder.ToString();
        }

        internal static string GeneratorRandomNQSCode(int length)
        {
            byte[] buff = GeneratorRandomBuffer(length);
            StringBuilder builder = new StringBuilder();
            Func<byte, int> convert = new Func<byte, int>(bt => bt % 95 == 0x02 || bt % 95 == 0x3C ? 94 : bt % 95 );
            for(int i = 0; i < length; i++) { builder.Append(CharsMap[convert(buff[i])]); }
            return builder.ToString();
        }
    }
}