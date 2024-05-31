using System.Collections.Generic;

namespace LeetCode.Stack
{
    public class ValidParenthesis
    {
        public bool IsValid(string s) 
        {
            Stack<char> opener = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[' )
                {
                    opener.Push(c);
                }
                    
                else if (c == ')') 
                {
                    if (opener.Count == 0 || opener.Pop() != '(' )
                    {
                        return false;
                    }
                } 
                else if (c == '}')
                {
                    if (opener.Count == 0 || opener.Pop() != '{' )
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (opener.Count == 0 || opener.Pop() != '[' ){
                        return false;
                    }
                }
            }
            return opener.Count == 0;
        }   
    }
}