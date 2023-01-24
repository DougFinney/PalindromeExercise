using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }

        public bool IsAPalindrome(string word)
        {
            if (word== null || word.Length == 0)
            { 
                return false; 
            }
            
            var reversed = "";

            var noSpaces = word.Replace(" ", "");

            for (var i = noSpaces.Length - 1; i >= 0; i--)
            {
                reversed += noSpaces.ToLower()[i];
            }
            if(reversed == noSpaces.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
