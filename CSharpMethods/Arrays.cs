using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpMethods
{
    class Arrays
    {
        #region Sort the Array - Bubblesort?

        #endregion

        #region Merge 2 sorted Arrays into one sorted Array
        public int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int length = array1.Length + array2.Length;
            int[] returnArray = new int[length];
            int index = 0;
            int x = 0;
            int y = 0;

            while (x < array1.Length && y < array2.Length)
            {
                if (array1[x] > array2[y]) // && x != array1.Length
                {
                    returnArray[index] = array2[y];
                    y++;
                }
                else //if(y != array2.Length)
                {
                    returnArray[index] = array1[x];
                    x++;
                }
                index++;
            }

            //Store remaining elements in array1 (if any)
            while (x < array1.Length)
            {
                returnArray[index] = array2[x];
                x++;
            }
            //Store remaining elements in array2 (if any)
            while (y < array2.Length)
            {
                returnArray[index] = array2[y];
                y++;
            }

            return returnArray;
        }
        #endregion

        #region Most frequent element in an Array
        //Most frequent word in an array of strings
        //https://www.geeksforgeeks.org/frequent-element-array/
        public int GetElementOccurMost(int[] array)
        {
            //string[] stringArray = userInput.Split(" "); //If taking in String as input.  Need to consider \r\n and \t.  Do another split on each?
            Dictionary<int, int> elemList = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (!elemList.ContainsKey(element))
                {
                    elemList.Add(element, 1);
                }
                else
                {
                    elemList[element] = elemList[element] + 1;
                }
            }

            var keyOfMaxValue = elemList.Aggregate((element1, element2) => element1.Value > element2.Value ? element1 : element2).Key;
            //Console.WriteLine("Word occurs most: " + keyOfMaxValue);
            //var maxValue = wordList.Values.Max();
            //Console.WriteLine("Number of duplicates: " + maxValue);

            return keyOfMaxValue;
        }


        #endregion

        #region Sort an array of 0s, 1s and 2s
        //https://www.geeksforgeeks.org/sort-an-array-of-0s-1s-and-2s/
        /* Works by leaving current element in place or by swapping with the next element in line at the front or the end

            Input array   =  [0, 1, 0, 1, 0, 0, 1, 1, 1, 0]
            l=low, m=med, h=high

            lm								  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            lm							  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            l  m						  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            l	  m						  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	               l	 m					  h
            {0, 0, 1, 1, 1, 2, 1, 2, 0, 0, 0, 1}
	               l		m				  h
            {0, 0, 1, 1, 1, 2, 1, 2, 0, 0, 0, 1}
	               l		m			   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l		   m		   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l			  m		   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l			  m		h
            {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 2, 2}
		              l				 m	h
            {0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 2, 2}
			             l				mh
            {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 2, 2}
				            l			h  m
            {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2}

            Output array =  [0, 0, 0, 0, 0, 1, 1, 1, 1, 1]
            */
        public void sortArr(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0, temp = 0;
            //Console.WriteLine("lo: {0}, mid: {1}, high: {2}", low, mid, high);

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        {
                            temp = arr[low];
                            arr[low] = arr[mid];
                            arr[mid] = temp;
                            low++;
                            mid++;
                            //Console.WriteLine("Case 0.  lo: {0}, mid: {1}, high: {2} New Array: {3}", low, mid, high, ArrayAsString(arr));
                            break;
                        }
                    case 1:
                        {
                            mid++;
                            //Console.WriteLine("Case 1.  lo: {0}, mid: {1}, high: {2} New Array: {3}", low, mid, high, ArrayAsString(arr));
                            break;
                        }
                    case 2:
                        {
                            temp = arr[mid];
                            arr[mid] = arr[high];
                            arr[high] = temp;
                            high--;
                            //Console.WriteLine("Case 2.  lo: {0}, mid: {1}, high: {2} New Array: {3}", low, mid, high, ArrayAsString(arr));
                            break;
                        }
                }
            }
            Console.WriteLine("Final sorted 0's, 1's, and 2's array: " + ArrayAsString(arr));
            /* 
            Works by leaving current element in place or by swapping with the next element in line at the front or the end
            l=low, m=med, h=high
            lm								  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            lm							  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            l  m						  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	            l	  m						  h
            {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
	               l	 m					  h
            {0, 0, 1, 1, 1, 2, 1, 2, 0, 0, 0, 1}
	               l		m				  h
            {0, 0, 1, 1, 1, 2, 1, 2, 0, 0, 0, 1}
	               l		m			   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l		   m		   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l			  m		   h
            {0, 0, 1, 1, 1, 1, 1, 2, 0, 0, 0, 2}
	               l			  m		h
            {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 2, 2}
		              l				 m	h
            {0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 2, 2}
			             l				mh
            {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 2, 2}
				            l			h  m
            {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2}
            */


            //Below requires 2 traversals of the array while the above requires 1
            //int i, cnt0 = 0, cnt1 = 0, cnt2 = 0;

            //// Count the number of 0s, 1s and 2s in the array 
            //for (i = 0; i < n; i++)
            //{
            //    switch (arr[i])
            //    {
            //        case 0:
            //            cnt0++;
            //            break;
            //        case 1:
            //            cnt1++;
            //            break;
            //        case 2:
            //            cnt2++;
            //            break;
            //    }
            //}

            //// Update the array 
            //i = 0;

            //// Store all the 0s in the beginning 
            //while (cnt0 > 0)
            //{
            //    arr[i++] = 0;
            //    cnt0--;
            //}

            //// Then all the 1s 
            //while (cnt1 > 0)
            //{
            //    arr[i++] = 1;
            //    cnt1--;
            //}

            //// Finally all the 2s 
            //while (cnt2 > 0)
            //{
            //    arr[i++] = 2;
            //    cnt2--;
            //}

            //// Print the sorted array printArr(arr, n);
        }
        #endregion



        #region Find first continuous sub-array which adds to a given sum
        //https://www.geeksforgeeks.org/find-subarray-with-given-sum-in-array-of-integers/
        public string SubArrayWithSum(int[] arr, int sum)
        {
            //cur_sum to keep track of cummulative sum till that point  
            int cur_sum = 0;
            int start = 0;
            int end = -1;
            int arrayLength = arr.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arrayLength; i++)
            {
                cur_sum = cur_sum + arr[i];

                //check whether cur_sum - sum = 0, if 0 it means the sub array is starting from index 0- so stop  
                if (cur_sum - sum == 0)
                {
                    start = 0;
                    end = i;
                    break;
                }

                //if dict already has the value, means we already have subarray with the sum - so stop  
                if (dict.ContainsKey(cur_sum - sum))
                {
                    start = dict[cur_sum - sum] + 1;
                    end = i;
                    break;
                }

                //if value is not present then add to hashmap  
                dict[cur_sum] = i;
            }

            // if end is -1 : means we have reached end without the sum  
            if (end == -1)
            {
                //Console.WriteLine("No subarray with given sum exists");
                return "No subarray with given sum exists";
            }
            else
            {
                //Console.WriteLine("Sum found between indexes " + start + " to " + end);
                //Sum found between indexes:
                return start + " to " + end;
            }
        }
        #endregion

        #region //Find the largest sum in a continuous subarray (containing at least one number)
        //[-2, -1, 0, 5, -7, 3, 10]    
        public int FindSum(int[] nums)
        {
            int returnSum = int.MaxValue * -1; // * -1 to negate and make as small as possible
            int currentSum = 0;

            for (int x = 0; x < nums.Length; x++)
            {
                currentSum += nums[x];

                if (currentSum > returnSum)
                {
                    returnSum = currentSum;
                }
            }

            return returnSum;
        }
        #endregion

        #region Find index where sum on the right equals sum on the left
        public int IndexSumLeftRightEqual(int[] array)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int x = 1; x != array.Length; x++)
            {
                rightSum += array[x];
            }

            for (int i = 0; i < array.Length; i++)
            {

                if (i != 0)
                {
                    leftSum += array[i - 1];
                    rightSum -= array[i];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }

            }

            return 0;
        }
        #endregion

        #region //Find the first two numbers (or their indexes) and return int[2] whose sum equals the target Sum.
        //https://www.geeksforgeeks.org/given-an-array-a-and-a-number-x-check-for-pair-in-a-with-sum-as-x/
        //int[] numList = { 1, 3, 5, 7, 9 } //1 + 7 = 8 with indexes (0,3) or 3 + 5 = 8 with indexes (1,2)
        public int[] FindElementsForTarget(int[] nums, int targetValue)
        {
            int[] returnArray = { -1, -1 };

            if (nums == null || nums.Length < 2)
            {
                return null;
            }

            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[x] + nums[y] == targetValue)
                    {
                        //Values/Numbers
                        returnArray[0] = nums[x];
                        returnArray[1] = nums[y];

                        //Indexes
                        //returnArray[0] = x;
                        //returnArray[1] = y;

                        return returnArray;
                    }
                }
            }

            return returnArray;
        }
        #endregion

        //Find the first 3 numbers (or their indexes) and return int[3] where their sum equals the target Sum.
        //Combination of 3 numbers to match sum in array

        #region Find a triplet such that sum of two equals to third element
        //https://www.geeksforgeeks.org/find-triplet-sum-two-equals-third-element/
        public string FindTriplet(int[] arr)
        {
            int start, end;
            int arrayLength = arr.Length;

            //Sort the array
            Array.Sort(arr);

            //For every element in arr check if a pair exist(in array) whose sum is equal to arr element 
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                start = 0;
                end = i - 1;

                while (start < end)
                {
                    if (arr[i] == arr[start] + arr[end])
                    {
                        //Pair found 
                        return arr[start] + " + " + arr[end] + " = " + arr[i];
                    }
                    else if (arr[i] > arr[start] + arr[end])
                    {
                        start += 1;
                    }
                    else
                    {
                        end -= 1;
                    }
                }
            }

            return "No such triplet exists";
        }
        #endregion

        #region Count all triplets of int array such that the sum of two elements equals the third element
        //https://practice.geeksforgeeks.org/problems/count-the-triplets/0
        public string FindAllTriplets(int[] arr)
        {
            int start, end;
            int arrayLength = arr.Length;
            StringBuilder TripletsFound = new StringBuilder();

            //Sort the array
            Array.Sort(arr);

            //For every element in arr check if a pair exist(in array) whose sum is equal to arr element 
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                start = 0;
                end = i - 1;

                while (start < end)
                {
                    if (arr[i] == arr[start] + arr[end])
                    {
                        // pair found 
                        TripletsFound.Append(arr[start] + " + " + arr[end] + " = " + arr[i] + "\r\n");
                        start++;
                        end--;
                    }
                    else if (arr[i] > arr[start] + arr[end])
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            return TripletsFound.ToString();
        }
        #endregion


        #region Find all leaders in an array.  Leader is an element whose value is >= all elements to the right of it
        //public static List<int> FindLeaders(int[] arr)
        public string FindLeaders(int[] arr)
        {
            List<int> leaderList = new List<int>(); //List because size is variable.  Array size must be declared from start
            int leader;

            for (int i = 0; i < arr.Length; i++)
            {
                leader = -1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        leader = arr[i];
                    }
                    else
                    {
                        break;
                    }
                }

                if (leader != -1 || i == arr.Length - 1)
                {
                    leaderList.Add(arr[i]);
                }
            }

            string finalLeaderList = string.Join(", ", leaderList);

            return finalLeaderList;
        }
        #endregion

        #region Max water trapped in array "containers"
        //https://www.geeksforgeeks.org/trapping-rain-water/
        public int MaxWater(int[] array)
        {
            int water = 0;
            int left, right;
            int arrayLength = array.Length;

            // Will add to the water total each time there are elements greater than the current on both left and right sides.
            //for (int i = 0; i < arrayLength - 1; i++)
            for (int i = 0; i < arrayLength; i++)
            {
                // Find the maximum element on its left
                left = array[i];
                //for (int j = 0; j < i; j++)
                for (int j = i - 1; j != -1; j--)
                {
                    left = Math.Max(left, array[j]);
                }

                // Find the maximum element on its right
                right = array[i];
                for (int j = i + 1; j < arrayLength; j++)
                {
                    right = Math.Max(right, array[j]);

                    if (right > left)
                    {
                        break; //Save some iterations
                    }
                }

                // Update the maximum water
                water += (Math.Min(left, right) - array[i]);
            }

            return water;
        }
        #endregion

        //Similar: Container With Most Water
        //https://leetcode.com/problems/container-with-most-water/


        #region 


        #endregion


        #region

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
    }
}
