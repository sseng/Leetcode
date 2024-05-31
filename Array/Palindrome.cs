using System;

namespace LeetCode.Array
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // if number is odd length, ignore middle digit.
            return x == revertedNumber || x == revertedNumber/10;
        }

        public void Test(int x)
        {
            if (IsPalindrome(x))
                Console.WriteLine("Yes");
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
