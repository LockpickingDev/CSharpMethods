using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace CSharpMethods
{
    class ListClass
    {
        //TODO: most frequent element in list



        // Given a list of words, group words that are anagrams into separate lists. Then return a list containing these anagram lists.
        //Anagram - Word formed by rearranging the letters of another
        public Dictionary<string, List<string>> FindAnagrams(List<string> words)
		{
			Dictionary<string, List<string>> AnagramList = new Dictionary<string, List<string>>();

			for (int i = 0; i < words.Count; i++)
			{
				string sortedWord = SortCharsAscending(words[i]);

				if (AnagramList.ContainsKey(sortedWord))
				{

					AnagramList[sortedWord].Add(words[i]);
				}
				else
				{

					AnagramList.Add(sortedWord, new List<string> { words[i] });
				}

			}

			return AnagramList;
		}







        #region //Sort a string's characters in ASCII ascending order
        private string SortCharsAscending(string str)
        {
            char[] arr1;
            char ch;
            int i, j;
            string orderedString = "";
            //int l = str.Length;
            arr1 = str.ToCharArray(0, str.Length); //String.ToCharArray(int startIndex, int length)

            //(O) N^2
            for (i = 1; i < str.Length; i++)
            {
                for (j = 0; j < str.Length - i; j++)
                {
                    if (Char.ToLower(arr1[j]) > Char.ToLower(arr1[j + 1]))
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
                }
            }

            //Finished
            foreach (char c in arr1)
            {
                //ch = c;
                //Console.Write("{0} ", ch);
                orderedString += c;
            }

            return orderedString;
        }
        #endregion

    }//class ListClass
}//namespace CSharpMethods
