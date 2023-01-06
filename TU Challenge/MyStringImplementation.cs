using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Trim() == "")
            {
                return true;
            }

            return false;
        }

        public static string MixString(string a, string b)
        {
            int minLength = 0;
            int maxLength = 0;
            int restLength = 0;
            bool firstStringLonger = true;
            string resultString = "";

            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }

            int aLength = a.Length;
            int bLength = b.Length;


            if (aLength > bLength)
            {
                minLength = bLength;
                maxLength = aLength;
                firstStringLonger = true;
            }
            else
            {
                minLength = aLength;
                maxLength = bLength;
                firstStringLonger = false;
            }

            restLength = maxLength - minLength;

            for (int i = 0; i < minLength; i++)
            {
                resultString += a[i];
                resultString += b[i];
            }


            if (firstStringLonger)
            {
                for (int i = 0; i < restLength; i++)
                {
                    resultString += a[i + minLength];
                }
            }
            else
            {
                for (int i = 0; i < restLength; i++)
                {
                    resultString += b[i + minLength];
                }
            }

            return resultString;
        }

        public static string ToLowerCase(string a)
        {
            string resultString = "";

            for (int i = 0; i < a.Length; i++)
            {
                resultString += Char.ToLower(a[i]);
            }

            return resultString;
        }

        public static string Voyelles(string a)
        {
            string resultString = "";
            
            for (int i = 0; i < a.Length; i++)
            {
                a = ToLowerCase(a);

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y')
                {
                    if (!resultString.Contains(a[i]))
                    {
                        resultString += a[i];
                    }
                }
            }

            return resultString;
        }

        public static string Reverse(string a)
        {
            char[] cArray = a.ToCharArray();
            string resultString = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                resultString += cArray[i];
            }

            return resultString;
        }

        public static string BazardString(string input)
        {
            string resultString = "";

            for (int i = 0; i < input.Length; i += 2)
            {
                resultString += input[i];
            }

            for (int i = 1; i < input.Length; i += 2)
            {
                resultString += input[i];
            }

            return resultString;
        }

        public static string UnBazardString(string input)
        {
            string resultString = "";
            string stringA = "";
            string stringB = "";

            for (int i = 0; i < input.Length / 2; i++)
            {
                stringA += input[i];
            }

            for (int i = 0 + input.Length / 2; i < input.Length; i++)
            {
                stringB += input[i];
            }

            resultString = MixString(stringA, stringB);

            return resultString;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
