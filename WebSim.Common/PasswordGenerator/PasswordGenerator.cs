using System;

namespace WebSim.Common.PasswordGenerator
{
    public class PasswordGenerator : IPasswordGenerator
    {
        public string GetPassword()
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@_";
            char[] chars = new char[8];
            Random rd = new Random();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}