using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class RandomizePassword
    {
        public string GeneratePassword(int length)
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

            char[] randomPassword = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomPassword[i] = characters[random.Next(characters.Length)];
            }

            string generatedPassword = new string(randomPassword);
            return generatedPassword;
        }
    }
}
