using System;
using System.Collections.Generic;
using System.Text;

namespace ReversWordsWPF
{
    public class RearrangingWordsInSentence
    {
        /// <summary>
        /// разделение предложения на отдельные слова
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        string[] GetStringSplit(string inputString)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            string[] ArrayStringSplit = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return ArrayStringSplit;
        }

        /// <summary>
        /// перестановка слов местами
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
       public string RearrangingWords(string inputPhrase)
        {
            string[] ArrayString = GetStringSplit(inputPhrase);
            string ResultString = "";

            //Array.Reverse(ArrayString);
            for (int i = 0; i < ArrayString.Length / 2; i++) //перестановка слов в предложении
            {
                string temp = ArrayString[i];
                ArrayString[i] = ArrayString[ArrayString.Length - i - 1];
                ArrayString[ArrayString.Length - i - 1] = temp;
            }

            for (int i = 0; i < ArrayString.Length; i++) // вывод нового сообщения
            {
                ResultString += ArrayString[i] + " ";
            }
            return ResultString;
        }
    }
}
