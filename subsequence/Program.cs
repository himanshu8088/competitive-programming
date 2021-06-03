using System;

namespace subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            sol.Subsequence("123", "");      
        }
    } 

    public class Solution{

        public void Subsequence(string input, string output){
            if(input.Length==0){
                Console.WriteLine(output);
                return;
            }

            Subsequence(input.Substring(1), string.Concat(output,input[0]));
            Subsequence(input.Substring(1), output);
        }
    }
}
