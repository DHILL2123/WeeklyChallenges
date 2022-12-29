using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
                if (vals[i] == false)
                {
                    return true;
                }
            return false;
        
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int hold = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int num in numbers)
                if (num % 2 != 0)
                {
                    hold += num;
                }
            if (hold % 2 != 0)
            {
                return true;
            }
            return false;
        }
    

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char v = val.Last();
            return v;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
            if (divisor == 0)
            {
                return 0;
            }

            return dividend/divisor;



        }

        public int LastMinusFirst(int[] nums)
        {
            int firstOne = nums.First();
            int lastOne = nums.Last();

            return lastOne - firstOne;
        }

        public int[] GetOddsBelow100()
        {
            int oddsBelow100 = 0;
            var newList = new List<int>();
            while (oddsBelow100 < 100) 
            {
                oddsBelow100++;
                if (oddsBelow100 % 2 != 0)
                {
                    newList.Add(oddsBelow100);
                }
                
            }
            int[] newArray = newList.ToArray();
            return newArray;
            

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
