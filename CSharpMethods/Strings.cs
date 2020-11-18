using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpMethods
{
    class Strings
    {

        #region //Sort characters of the string in reverse order
        public string ReverseString(string str)
        {
            string reversedString = "";

            for(int x = str.Length - 1; x >= 0; x--)
            {
                reversedString += str[x];
            }

            return reversedString;
        }
        #endregion

        #region //Sort a string's characters in ASCII ascending order
        public string SortCharsAscending(string str)
        {
            char[] arr1 = str.ToCharArray(0, str.Length); //String.ToCharArray(int startIndex, int length)
            char ch;
            string orderedString = "";

            //(O) N^2
            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
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
                orderedString += c;
            }

            return orderedString;
        }
        #endregion

        #region //Does String contain all Unique Characters?
        public bool AllUniqueChars(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Sort(charArray); //Sort

            for(int i = 0; i < charArray.Length - 1; i++)
            {
                //Console.WriteLine("curr char: " + charArray[i]);
                if(charArray[i] == charArray[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region //Count total number of alphabetical, digits, and special characters
        //private int[] NumEachTypeCharacter(string str)
        public string NumEachTypeCharacter(string str)
        {
           Dictionary<string, int> CharTypeCount = new Dictionary<string, int>()
            {
                {"UpperAlpha", 0},
                {"LowerAlpha", 0},
                {"Digit", 0},
                {"Punctuation", 0},
                {"Separator", 0},  //Space, line, paragraph
                {"Symbol", 0},     //Currency, letterlike, subscript nums, superscript nums, math operators, geometric, technical, braille, dingbats
                {"WhiteSpace", 0},
                {"Other", 0}
            };
            
            int currentCount; //Current count of dictionary index
            StringBuilder CharCounts = new StringBuilder();
            CharCounts.Append("\r\n");
            int i = 0;
            int l = str.Length;


            while (i < l)
            {
                if (Char.IsLetter(str[i]) && Char.IsLower(str[i]))
                {
                    CharTypeCount.TryGetValue("LowerAlpha", out currentCount);
                    CharTypeCount["LowerAlpha"] = currentCount + 1;
                }
                else if (Char.IsLetter(str[i]) && Char.IsUpper(str[i]))
                {
                    CharTypeCount.TryGetValue("UpperAlpha", out currentCount);
                    CharTypeCount["UpperAlpha"] = currentCount + 1;
                }
                else if (Char.IsDigit(str[i]))
                {
                    CharTypeCount.TryGetValue("Digit", out currentCount);
                    CharTypeCount["Digit"] = currentCount + 1;
                }
                else if (Char.IsPunctuation(str[i]))
                {
                    CharTypeCount.TryGetValue("Punctuation", out currentCount);
                    CharTypeCount["Punctuation"] = currentCount + 1;
                }
                else if (Char.IsSeparator(str[i]))
                {
                    CharTypeCount.TryGetValue("Separator", out currentCount);
                    CharTypeCount["Separator"] = currentCount + 1;
                }
                else if (Char.IsSymbol(str[i]))
                {
                    CharTypeCount.TryGetValue("Symbol", out currentCount);
                    CharTypeCount["Symbol"] = currentCount + 1;
                }
                else if (Char.IsWhiteSpace(str[i]))
                {
                    CharTypeCount.TryGetValue("WhiteSpace", out currentCount);
                    CharTypeCount["WhiteSpace"] = currentCount + 1;
                }
                else
                {
                    CharTypeCount.TryGetValue("Other", out currentCount);
                    CharTypeCount["Other"] = currentCount + 1;
                }


                i++;
            }

            foreach (KeyValuePair<string, int> kvp in CharTypeCount)
            {
                //CharCounts.AppendLine("Key = " + kvp.Key + ", Value = " + kvp.Value);
                CharCounts.AppendLine(kvp.Key + " = " + kvp.Value);
                //CharCounts.Append("<span style=\"padding-left: 10px;\">" + kvp.Key + " = " + kvp.Value + "</span><br />");
            }

            //return NumEachChar;
            return CharCounts.ToString();
        }
        #endregion

        #region //Find character that appears most in string
        public string CharAppearsMost(string str)
        {
            int[] ch_fre = new int[255];
            int i, max; //max = ascii code
            int ascii;
            string characterAppearMost;
            int l = str.Length;

            for (i = 0; i < 255; i++)  //Set frequency of all characters to 0
            {
                ch_fre[i] = 0;
            }

            //Read for frequency of each characters
            i = 0;
            while (i < l)
            {
                ascii = (int)str[i]; //Position of char in ascii sequence
                ch_fre[ascii] += 1;
                i++;
            }
            // Console.Write("{0}  ",(char)65);
            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (ch_fre[i] > ch_fre[max])
                    {
                        max = i;
                    }
                }
            }

            characterAppearMost = ((char)max).ToString();

            return characterAppearMost;
        }
        #endregion

        //Kth most frequent Character in a given String
        //https://www.geeksforgeeks.org/kth-most-frequent-character-in-a-given-string/?ref=rp

        #region //Find Max consecutive repeating Char in String
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        public char MaxConsecRepeatChar(string userString)
        {
            //Same as Longest Substring WITH Repeating Characters except return first char in longestSubstring instead of whole string
            string longestSubstring = "";
            string tempString = userString[0].ToString();

            for (int i = 1; i < userString.Length; i++)
            {
                if (tempString.Contains(userString[i]))
                {
                    tempString += userString[i].ToString();
                }
                else
                {
                    if (tempString.Length > longestSubstring.Length)
                    {
                        longestSubstring = tempString;
                    }

                    tempString = userString[i].ToString();
                }
            }

            return longestSubstring[0];
        }
        #endregion

        #region //Longest Substring WITH Repeating Characters str = "aaaaaabbcbbbbqwertybbbb"
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        public string LongestSubstringRepeating(string userString)
        //To Find Max consecutive repeating Char in String, change method declaration and return first Char in tempString. 
        //public char MaxConsecRepeatChar(string userString)
        {
            string longestSubstring = "";
            //string tempString = "";
            string tempString = userString[0].ToString();

            for (int i = 1; i < userString.Length; i++)
            {
                if (tempString.Contains(userString[i]))
                {
                    tempString += userString[i].ToString();
                }
                else
                {
                    if (tempString.Length > longestSubstring.Length)
                    {
                        longestSubstring = tempString;
                    }

                    tempString = userString[i].ToString();
                }
            }

            //return tempString[0];
            return longestSubstring;
        }
        #endregion

        #region //Longest Substring Without Repeating Characters
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        public string LongestSubstringNoRepeat(string userString)
        {
            string longestSubstring = "";
            string tempString = "";

            for (int i = 0; i < userString.Length; i++)
            {
                if (!tempString.Contains(userString[i]))
                {
                    tempString += userString[i].ToString();
                }
                else
                {
                    if (tempString.Length > longestSubstring.Length)
                    {
                        longestSubstring = tempString;
                    }

                    tempString = "";
                }


            }

            return longestSubstring;
        }
        #endregion

        #region //Remove ALL duplicate Chars from String/Char Array while keeping 1st instance of the duplicates
        public String RemoveDuplicateChars(string userInput)
        {
            int stringLength = userInput.Length;
            int index = 0; //Used as index in the modified string 
            char[] str = userInput.ToCharArray();

            //Traverse through all characters 
            for (int i = 0; i < stringLength; i++)
            {

                //Check if str[i] is present before it  
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                //If not present, then add it to result. 
                if (j == i)
                {
                    str[index++] = str[i];
                }
            }
            char[] ans = new char[index];
            Array.Copy(str, ans, index);
            return String.Join("", ans);
        }
        #endregion

        #region //Find longest common prefix from Array of Strings
        //TODO: Fails with string where each word has same letters: "prefix prefxi prexif"
        public string CommomLongestPrefix(string userInput)
        {
            string output = "";
            string longestPrefix = "";
            bool isValid = false;

            string[] inputArray = userInput.Split(' ');

            if (inputArray == null)
            {
                return string.Empty;
            }

            Dictionary<char, int> dictionary = new Dictionary<char, int>(); //Represents a collection of keys and values.

            foreach (string str in inputArray)
            {
                foreach (char ch in str)
                {
                    if (!dictionary.ContainsKey(ch))
                    {
                        dictionary.Add(ch, 1); //Add 
                    }
                    else
                    {
                        if (output.IndexOf(ch) == -1)
                        {
                            output += ch;
                        }
                    }
                }
            }

            if (output == "")
            {
                return output;
            }
            else
            {
                foreach (char ch in output)
                {
                    foreach (string str in inputArray)
                    {
                        if (!str.Contains(ch))
                        {
                            isValid = true;
                            break;
                        }
                    }

                    if (!isValid)
                    {
                        longestPrefix += ch;
                    }
                }
            }

            return longestPrefix;
        }
        #endregion

        #region //All Permutations of string
        //permutation function @param string str to calculate permutation for @param l starting index to @param r end index
        //A string of length n has n! permutation
        //Permutations of string ABC: ABC ACB BAC BCA CBA CAB
        private string Permute(String str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = SwapChar(str, l, i);
                    Permute(str, l + 1, r);
                    str = SwapChar(str, l, i);
                }
            }

            return "result string created by string builder";
        }
        #endregion


        #region //Reverse the order of words in a String
        public string ReverseWords(string userInput)
        {
            string[] words = userInput.Split(" ");
            string reversedString = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedString += words[i] + " ";
            }

            return reversedString;
        }
        #endregion

        #region //Count the total number of words in a string
        public int CountNumWords(string str)
        {
            int l = 0;
            int word = 0;

            // && string.IsNullOrEmpty(str)
            if (!string.IsNullOrWhiteSpace(str)) //String not empty
            {
                word++;

                /* loop till end of string */
                while (l <= str.Length - 1)
                {
                    //Check whether the current character is white space, new line, or tab char and make sure none of them are at beginning or end of the string
                    if ((str[l] == ' ' || str[l] == '\n' || str[l] == '\t') && l != 0 && l != str.Length - 1)
                    {
                        word++;
                    }

                    l++;
                }
            }

            return word;
        }
        #endregion

        #region //Most frequent word in an array of strings
        //https://practice.geeksforgeeks.org/problems/most-frequent-word-in-an-array-of-strings/0
        public string GetWordOccurMost(string[] array)
        {
            //string[] stringArray = userInput.Split(" "); //If taking in String as input.  Need to consider \r\n and \t.  Do another split on each?
            Dictionary<string, int> wordList = new Dictionary<string, int>();

            foreach (string word in array)
            {
                if (!wordList.ContainsKey(word))
                {
                    wordList.Add(word, 1);
                }
                else
                {
                    wordList[word] = wordList[word] + 1;
                }
            }

            var keyOfMaxValue = wordList.Aggregate((element1, element2) => element1.Value > element2.Value ? element1 : element2).Key;
            //Console.WriteLine("Word occurs most: " + keyOfMaxValue);
            //var maxValue = wordList.Values.Max();
            //Console.WriteLine("Number of duplicates: " + maxValue);

            return keyOfMaxValue;
        }
        #endregion

        //Find the k most frequent words from a file
        //https://www.geeksforgeeks.org/find-the-k-most-frequent-words-from-a-file/?ref=rp

        #region //Count how many times a specified word appears in a string
        public int CountWordOccurrences(string document, string wordCounting)
        {
            //Works well except some words in array will be empty spaces because of spaces after punctuation like ', ' and '! '.  Try Reg Expressions instead of Char[]
            string[] stringArray = document.Split(new Char[] { ' ', ',', '.', '!', '?', ':', ';', '\n', '\t' });
            int numOccurrences = 0;

            foreach (string word in stringArray)
            {
                if (word == wordCounting)
                {
                    numOccurrences++;
                }
            }

            return numOccurrences;
        }
        #endregion

        #region Check if 2 Strings are Anagrams
        //Anagram - Word formed by rearranging the letters of another
        public bool CheckIfAnagrams(string word1, string word2)
        {
            string sortedWord1 = SortCharsAscending(word1);
            string sortedWord2 = SortCharsAscending(word2);

            if (sortedWord1 != sortedWord2)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region //Swap single Chars in string
        //Swap Characters at position @param a string value @param i position 1 @param j position 2 @return swapped string
        public string SwapChar(string userString, int i, int j)
        {
            if(userString.Length < 2)
            {
                return "String too small to swap chars!";
            }

            char[] charArray = userString.ToCharArray();
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string returnString = new string(charArray);
            return returnString;
        }
        #endregion

        



    }//class Strings
}//namespace CSharpMethods
