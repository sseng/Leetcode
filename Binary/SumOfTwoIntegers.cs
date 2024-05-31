namespace LeetCode.Binary
{
    //Given two integers a and b, return the sum of the two integers without using the operators + and -.
    public class SumOfTwoIntegers
    {
        private int a;
        private int b;

        public SumOfTwoIntegers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int GetSum()
        {
            while( b != 0)
            {
                int carry = (a & b) << 1;
                a = a ^ b;
                b = carry;
            }
            return a;
        }
    }
}