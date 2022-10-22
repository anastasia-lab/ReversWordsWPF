using System;
using System.Collections.Generic;
using System.Text;

namespace ReversWordsWPF
{
    class SplittingStringIntoWords
    {
        /// <summary>
        /// разделение предложения на массив слов
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private string[] GetArrayStringSplit(string inputString)
        {
            char[] separators = new char[] { ' ', '.', ',', '?', '!', ':', ';', '(', ')', '\"', '\"', '\'', '\'' };
            string[] ArrayStringSplit = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return ArrayStringSplit;
        }

        /// <summary>
        /// вывод каждого словоа в отдельной строке
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        private string SplittingString(string phrase)
        {
            string[] ArrayReversWord = GetArrayStringSplit(phrase);
            string outputString = "";

            for (int i = 0; i < ArrayReversWord.Length; i++)
            {
                outputString = outputString + ArrayReversWord[i];
            }

            return outputString;
        }

        /// <summary>
        /// Вывод результата разделения предложения
        /// </summary>
        /// <param name="InputUserPhrase"></param>
        /// <returns></returns>
        public List<string> Print(string InputUserPhrase)
        {
            List<string> listWords = new List<string>();
            string[] ArrayUserString = GetArrayStringSplit(InputUserPhrase);

            foreach (string SplitUserString in ArrayUserString)
            {
                string result = SplittingString(SplitUserString);
                listWords.Add(result);
            }

            return listWords;
        }
    }
}
