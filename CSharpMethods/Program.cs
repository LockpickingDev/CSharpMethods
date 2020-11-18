using System;
using System.Text;
using System.Collections.Generic;

namespace CSharpMethods
{
    class Program
    {
        //CHECK TODOs SAVED IN VS

        #region main
        static void Main(string[] args)
        {
            Program program = new Program();
            string choice = "";

            while (choice != "0")
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Strings");
                Console.WriteLine("2: Linked Lists");
                Console.WriteLine("3: Arrays");
                Console.WriteLine("4: ArrayList");
                Console.WriteLine("5: Lists");
                Console.WriteLine("6: HashTables");
                Console.WriteLine("7: Delegates");
                Console.WriteLine("8: Recursion");
                Console.WriteLine("9: Stack");
                Console.WriteLine("10: Heap");
                Console.WriteLine("11: Math");
                Console.WriteLine("12: Basic/Generic Methods");

                choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "0":
                        break;
                    case "1":
                        program.StringSection();
                        break;
                    case "2":
                        program.LinkedListSection();
                        break;
                    case "3":
                        program.ArraySection();
                        break;
                    case "4":
                        program.ArrayListSection();
                        break;
                    case "5":
                        program.ListsSection();
                        break;
                    case "6":
                        program.HashTablesSection();
                        break;
                    case "7":
                        program.DelegateSection();
                        break;
                    case "8":
                        program.RecursionSection();
                        break;
                    case "9":
                        program.StackSection();
                        break;
                    case "10":
                        program.HeapSection();
                        break;
                    case "11":
                        program.MathSection();
                        break;
                    case "12":
                        program.BasicsSection(); //Decimal To Binary, 
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            //Console.WriteLine("Any button to Exit");
            //Console.ReadLine();
        }
        #endregion

        #region StringSection
        public void StringSection()
        {
            Strings StringMethods = new Strings();

            Console.WriteLine("Enter a string to process: ");
            string userString = Console.ReadLine();
            
            Console.WriteLine("*** Sort characters of the string in reverse order");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.ReverseString(userString) + "\r\n");

            Console.WriteLine("*** Sort Chars in String in ASCII Ascending order");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.SortCharsAscending(userString) + "\r\n");

            Console.WriteLine("*** Does String contain all Unique Characters?");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.AllUniqueChars(userString) + "\r\n");

            Console.WriteLine("*** Count the total number of words in a string");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.CountNumWords(userString) + "\r\n");

            Console.WriteLine("*** Count total number of alphabetical, digits, and special characters");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.NumEachTypeCharacter(userString) + "\r\n");

            Console.WriteLine("*** Character that appears most in string");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.CharAppearsMost(userString) + "\r\n");

            //Max consecutive repeating Char in String
            Console.WriteLine("*** Max consecutive repeating Char in String:"); //aaaaaabbcbbbbqwertybbbb = a
            Console.WriteLine("String: " + userString + " , Max consecutive repeating Char: " + StringMethods.MaxConsecRepeatChar(userString) + "\r\n"); //string MaxConsecRepeatChar(string userString)

            //Longest Substring WITH Repeating Characters
            Console.WriteLine("*** Longest Substring WITH Repeating Characters:"); //aaaaaabbcbbbbqwertybbbb = aaaaaa
            Console.WriteLine("String: " + userString + " , Longest Substring: " + StringMethods.LongestSubstringRepeating(userString) + "\r\n"); //string LongestSubstringRepeating(string userString)

            //Longest Substring Without Repeating Characters
            Console.WriteLine("*** Longest Substring WITHOUT Repeating Characters:"); //aaaaaabbcbbbbqwertybbbb = bqwerty
            Console.WriteLine("String: " + userString + " , Longest Substring: " + StringMethods.LongestSubstringNoRepeat(userString) + "\r\n"); //string LongestSubstringNoRepeat(string userString)

            //TODO: Fails with string where each word has same letters: "prefix prefxi prexif"
            //Console.WriteLine("*** Find longest common prefix from Array of Strings");
            //Console.WriteLine("String using: " + userString);
            //Console.WriteLine("Result: " + StringMethods.CommomLongestPrefix(userString) + "\r\n");

            Console.WriteLine("*** Remove ALL duplicate Chars from String/Char Array while keeping 1st instance of the duplicates");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.RemoveDuplicateChars(userString) + "\r\n");

            Console.WriteLine("*** Swap single Chars in string at position 0 and 1");
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Result: " + StringMethods.SwapChar(userString, 0, 1) + "\r\n");

            //permutation function @param string str to calculate permutation for @param l starting index to @param r end index
            //A string of length n has n! permutation
            //Permutations of string ABC: ABC ACB BAC BCA CBA CAB
            //Console.WriteLine("*** All Permutations of string");
            //Console.WriteLine("String using: " + userString);
            //Console.WriteLine("Result: " + StringMethods.ReverseString(userString) + "\r\n");

            //Longest Substring Without Repeating Characters
            Console.WriteLine("*** Reverse the order of words in a String:"); //aaaaaabbcbbbbqwertybbbb = bqwerty
            Console.WriteLine("String using: " + userString);
            Console.WriteLine("Reversed: " + StringMethods.ReverseWords(userString) + "\r\n");

            Console.WriteLine("*** Most frequent word in a string or array of strings:");
            string mostFrequentWordString = "aaa bbb ccc bbb bbb ddd bbb eee"; //aaa bbb ccc bbb bbb ddd bbb eee
            string[] array7 = mostFrequentWordString.Split(" ");
            Console.WriteLine(ArrayAsString(array7));
            Console.WriteLine("Word that shows up most: " + StringMethods.GetWordOccurMost(array7) + "\r\n");

            Console.WriteLine("*** Count how many times a specified word appears in a string:");
            string countWordOccurencesString = "Hello, I am Dan.  List:\napple, banana, apple, apple; peach!\r\nIs that all?";
            Console.WriteLine(countWordOccurencesString);
            Console.WriteLine("Number occurrences of word apple: " + StringMethods.CountWordOccurrences(countWordOccurencesString, "apple") + "\r\n"); //public int CountWordOccurrences(string document, string wordCounting)


            //Are the two Strings Anagrams?
            Console.WriteLine("*** Are the two Strings Anagrams?");
            Console.WriteLine("Strings using: act, cat");
            Console.WriteLine("Result: " + StringMethods.CheckIfAnagrams("act", "bat") + "\r\n"); //"act", "cat"   "act", "bat"




        }
        #endregion

        #region LinkedListSection
        public void LinkedListSection()
        {
            Console.Clear();

            LinkedListClass LinkedListMethods = new LinkedListClass();
        }
        #endregion

        #region ArraySection
        public void ArraySection()
        {
            Console.Clear();

            Arrays ArrayMethods = new Arrays();



            
            Console.WriteLine("Merge 2 sorted Arrays into one sorted Array");
            int[] sortedArray1 = { 1, 3, 5, 7, 9, 11 };
            int[] sortedArray2 = { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine(ArrayAsString(sortedArray1));
            Console.WriteLine(ArrayAsString(sortedArray2));
            int[] sortedResult = ArrayMethods.MergeSortedArrays(sortedArray1, sortedArray2);
            Console.WriteLine("Arrays merged: ");
            Console.WriteLine(ArrayAsString(sortedResult) + "\r\n");

            Console.WriteLine("Find first continuous sub-array which adds to a given sum");
            int sum = 10;
            int[] array1 = { 1, 2, 3, 4, 7, 10 };
            Console.WriteLine(ArrayAsString(array1));
            Console.WriteLine("Sum of " + sum + " found between indexes " + ArrayMethods.SubArrayWithSum(array1, sum) + "\r\n");

            Console.WriteLine("Find index where sum on the right equals sum on the left");
            int[] array2 = { 1, 2, 3, 4, 7, 10 };
            Console.WriteLine(ArrayAsString(array2));
            Console.WriteLine("Index (0 = None): " + ArrayMethods.IndexSumLeftRightEqual(array2).ToString() + "\r\n");

            Console.WriteLine("Find a triplet such that sum of two equals to third element");
            int[] array3 = { 1, 2, 3, 4, 7, 10 };
            Console.WriteLine(ArrayAsString(array3));
            Console.WriteLine(ArrayMethods.FindTriplet(array3) + "\r\n");

            Console.WriteLine("Count all triplets of int array such that the sum of two elements equals the third element");
            int[] array4 = { 1, 2, 3, 4, 7, 10 };
            Console.WriteLine(ArrayAsString(array4));
            Console.WriteLine(ArrayMethods.FindAllTriplets(array4) + "\r\n");

            Console.WriteLine("Find all leaders in an array.  Leader is an element whose value is >= all elements to the right of it");
            int[] leaderArray = { 1, 10, 3, 4, 7, 1 };
            Console.WriteLine(ArrayAsString(leaderArray));
            Console.WriteLine(ArrayMethods.FindLeaders(leaderArray) + "\r\n");

            Console.WriteLine("Max water trapped in array \"containers\"");
            int[] arrayForWater = { 3, 0, 2, 0, 4 }; //10  { 2, 0, 2 }; //2  { 3, 0, 2, 0, 4 }; //7  { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }; //6
            Console.WriteLine(ArrayAsString(arrayForWater));
            Console.WriteLine("Result: " + ArrayMethods.MaxWater(arrayForWater).ToString() + "\r\n");

            Console.WriteLine("Find the first two numbers (or their indexes) and return int[2] whose sum equals the target Sum.");
            int[] array5 = { 1, 3, 5, 7, 9 }; //
            int targetSum = 100;
            Console.WriteLine(ArrayAsString(array5));
            int[] indexResult = ArrayMethods.FindElementsForTarget(array5, targetSum); //int[] FindIndex(int[] nums, int targetValue)
            Console.WriteLine("First numbers/indexes found for targetSum of " + targetSum + ": " + (indexResult[0].ToString() != "-1" ? indexResult[0].ToString() : "NoneFound") + ", " + (indexResult[1].ToString() != "-1" ? indexResult[1].ToString() : "NoneFound") + "\r\n");



            
            Console.WriteLine("Sort Array with 0's, 1's, and 2's: ");
            int[] zerosOnesTwos = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 }; //Output: {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2}
            Console.WriteLine(ArrayAsString(zerosOnesTwos));
            ArrayMethods.sortArr(zerosOnesTwos);
            //Console.WriteLine( + "\r\n");


            //TODO: Finish this method
            //Console.WriteLine("Find the largest sum in a contiguous subarray (containing at least one number)");
            //int[] array6 = { -2, -1, 0, 5, -7, 3, 10 };
            //Console.WriteLine(ArrayAsString(array6));
            //Console.WriteLine(ArrayMethods.FindSum(array6) + "\r\n");

            //Console.WriteLine("");
            //int[] array7 = { 1, 2, 3, 4, 7, 10 };
            //Console.WriteLine(ArrayAsString(array7));
            //Console.WriteLine(ArrayMethods.MethodName(array7) + "\r\n");

            //Console.WriteLine("");
            //int[] array7 = { 1, 2, 3, 4, 7, 10 };
            //Console.WriteLine(ArrayAsString(array7));
            //Console.WriteLine(ArrayMethods.MethodName(array7) + "\r\n");

        }
        #endregion

        #region ArrayListSection
        public void ArrayListSection()
        {
            Console.Clear();

            ArrayListClass ArrayListMethods = new ArrayListClass();
        }
        #endregion

        #region ListsSection
        public void ListsSection()
        {
            ListClass ListMethods = new ListClass();

            //Anagrams - Given a list of words, group words that are anagrams into separate lists
            List<string> anagramWords = new List<string> { "cat", "bat", "eat", "ate", "tea" };
            Dictionary<string, List<string>> AnagramList = ListMethods.FindAnagrams(anagramWords);
            Dictionary<string, List<string>>.ValueCollection wordLists = AnagramList.Values;
            int i = 0;
            foreach (List<string> wordListItem in wordLists)
            {
                i++;
                Console.WriteLine("*** List {0} ***", i);
                foreach (string word in wordListItem)
                {
                    Console.WriteLine("Word = {0}", word);
                }
            }



            //Console.WriteLine(":");
            //ListMethods.PrintNNatural(1, 10);
        }
        #endregion

        #region HashTablesSection
        public void HashTablesSection()
        {
            Console.Clear();

            HashTableClass HashTableMethods = new HashTableClass();
        }
        #endregion

        #region DelegateSection
        public void DelegateSection()
        {
            Console.Clear();

            DelegateClass DelegeateMethods = new DelegateClass();
        }
        #endregion

        #region RecursionSection
        //https://www.w3resource.com/csharp-exercises/recursion/index.php

        public void RecursionSection()
        {
            Recursion RecursionMethods = new Recursion();

            Console.WriteLine("Print the first n natural numbers:");
            RecursionMethods.PrintNNatural(1, 10); //PrintNNatural(int startValue, int n)

            Console.WriteLine("Print numbers from n to 1:");
            RecursionMethods.PrintNNaturalBackwards(10); 




        }
        #endregion

        #region StackSection
        public void StackSection()
        {
            Console.Clear();

            StackClass StackMethods = new StackClass();
        }
        #endregion

        #region HeapSection
        public void HeapSection()
        {
            Console.Clear();

            HeapClass HeapMethods = new HeapClass();
        }
        #endregion

        #region MathSection
        public void MathSection()
        {
            MathClass MathMethods = new MathClass();

            Console.WriteLine("Clock angle at 3:30 = {0}", MathMethods.findClockAngle(3, 30));
            //Console.WriteLine("Clock angle at 12:00 = {0}", MathMethods.findClockAngle(12, 0));
            
            //MathMethods.findClockAngle(10, 30);


        }
        #endregion

        #region BasicsSection
        public void BasicsSection()
        {
            Basic BasicMethods = new Basic();

            //Console.WriteLine("Decimal To Binary:");
            //BasicMethods.DecimalToBinary();

            Console.WriteLine("Text Triangle of specified character and width:");
            BasicMethods.DisplayTextTriangle();

            //Console.WriteLine("Clock angle at 3:30 = {0}", BasicMethods.findClockAngle(3, 30));
            //Console.WriteLine("Clock angle at 12:00 = {0}", MathMethods.findClockAngle(12, 0));

            //MathMethods.findClockAngle(10, 30);


        }
        #endregion


        #region Show Array as a string
        public static string ArrayAsString(int[] array)
        {
            StringBuilder arrayString = new StringBuilder();
            arrayString.Append("Array Using: {");

            for (int i = 0; i < array.Length; i++)
            {
                arrayString.Append(array[i].ToString() + ", ");
            }

            arrayString.Remove((arrayString.Length - 2), 2);
            arrayString.Append("}");

            return arrayString.ToString();
        }

        public static string ArrayAsString(string[] array)
        {
            StringBuilder arrayString = new StringBuilder();
            arrayString.Append("Array Using: {");

            for (int i = 0; i < array.Length; i++)
            {
                arrayString.Append(array[i].ToString() + ", ");
            }

            arrayString.Remove((arrayString.Length - 2), 2);
            arrayString.Append("}");

            return arrayString.ToString();
        }
        #endregion


        #region Character Methods
        //TODO: Implement page for these
        public string VowelDigitOther(char symbol)
        {
            string result;

            if ((Char.ToLower(symbol) == 'a') || (Char.ToLower(symbol) == 'e') || (Char.ToLower(symbol) == 'i') || (Char.ToLower(symbol) == 'o') || (Char.ToLower(symbol) == 'u'))
            {
                result = "It's a vowel.";
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                result = "It's a digit.";
            }
            else
            {
                result = "It's another symbol.";
            }

            return result;
        }

        #endregion



    }//class Program
}//namespace CSharpMethods
