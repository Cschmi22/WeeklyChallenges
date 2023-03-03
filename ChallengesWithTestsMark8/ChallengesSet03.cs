﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }

            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber) && password.Any(char.IsUpper) && password.Any(char.IsLower);

            //bool isLetter = false;
            //bool isDigit = false;
            //bool isUpper = false;

            //foreach (var letter in password)
            //{
            //    if (char.IsLower(letter))
            //    {
            //        isLetter = true;
            //    }
            //    if (char.IsDigit(letter))
            //    {
            //        isDigit = true;
            //    }
            //    if (char.IsUpper(letter))
            //    {
            //        isUpper = true;
            //    }
            //}
            //return isUpper && isLetter && isDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            { 
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
         return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
