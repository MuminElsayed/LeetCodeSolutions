using System;

public class LeetCodeSolutions
{
    //#1
    //Problem link: https://leetcode.com/problems/palindrome-number/

    /*
	* Solution:
	* 1- Loop through first half of int
	* 2- Compare each one with the other side (ex: x = 123456, is 1 = 6; 2 = 5; etc..)
	* 3- Return true while no differences are found
	*/

    public static bool PalindromeNumber(int x)
    {
		//Step 1: Loop through first half of int
		//Get int length
		int numLength = x.ToString().Length;
		//Loop through half of it
		bool result = true;
		for (int i = 0; i < numLength/2; i++)
        {
			//Compare left side with right side
			if (x.ToString()[i] != x.ToString()[numLength - i - 1])
            {
				result = false;
				break;
            }
        }
		return result;
    }

    //#2
    //Link: https://leetcode.com/problems/two-sum/
    
    //Solution: Loop through the nums array and check if there exists a sum for it, if found then add it to the dictionary.

    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                int result;
                map.TryGetValue(complement, out result);
                return new int[] { result, i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        return null;
    }

    //#3
    //Link: https://leetcode.com/problems/roman-to-integer/

    //Solution summary: Set a hashtable for the roman letters, loop through string and translate it, also check if previous letter causes subraction

    public int RomanToInt(string s)
    {
        int result = 0;
        var romanMap = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
            {
                //If first number is smaller than next one = subtract (Roman magic)
                result -= romanMap[s[i]];
            }
            else
            {
                result += romanMap[s[i]];
            }
        }

        return result;
    }

    //#4
    //https://leetcode.com/problems/longest-common-prefix/

    //Solution: take the first word, and compare its letters with the remaining words, if letter matches, add to result string. Recurse until false.

    public string LongestCommonPrefix(string[] strs)
    {
        //Exit conditions
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        //Go through the same letter index in each word
        for (int i = 0; i < strs[0].Length; i++) //Loop through the letters of the first word (i = letters)
        {
            char currentLetter = strs[0][i]; //Get the current letter
            for (int j = 0; j < strs.Length; j++) //Loop through all words (j = words)
            {
                //Compare the letter with the same index in all the other words
                if (strs[j].Length == i || strs[j][i] != currentLetter) //If the letter doesn't match, or if the word is shorter than the current letter index, then exit
                {
                    return strs[0].Substring(0, i); //Exit returning the matching letters so far
                }
            }
        }
        return strs[0]; //If reached here, then the first word matches all other words
    }
}
