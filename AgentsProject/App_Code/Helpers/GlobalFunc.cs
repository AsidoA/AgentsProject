 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace BLL
{
    public class GlobalFunc
    {
        public static string GetRandomStr(int Size)//יצירת שמות לתמונות 
        {
            string RetVal = "";
            string Chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random Rnd = new Random();


            for (int i = 0; i < Size; i++)
            {
                int index = Rnd.Next(0, Chars.Length);

                RetVal += Chars[index];
            }

            return RetVal;
        }

        public static string passConvert(string rawData)//הצפנת סיסמאות 
        {
            // Create a SHA256  
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length/2; i++)
                {
                    builder.Append(bytes[i].ToString("x1"));
                }
                return builder.ToString();
            }
        }
        public static string IntToCurrencyString(int number, string separator)
        {
            string moneyReversed = "";

            string strNumber = number.ToString();

            int processedCount = 0;

            for (int i = (strNumber.Length - 1); i >= 0; i--)
            {
                moneyReversed += strNumber[i];

                processedCount += 1;

                if ((processedCount % 3) == 0 && processedCount < strNumber.Length)
                {
                    moneyReversed += separator;
                }
            }

            string money = "";

            for (int i = (moneyReversed.Length - 1); i >= 0; i--)
            {
                money += moneyReversed[i];
            }

            return money;
        }//מספר לכסף
    }
}