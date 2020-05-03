using System;
using System.Linq;

namespace _003_Ransom_Note
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an arbitrary ransom note string and another string containing letters from all the magazines, 
               write a function that will return true if the ransom note can be constructed from the magazines ; 
               otherwise, it will return false.
  
             * Each letter in the magazine string can only be used once in your ransom note.
  
             * Note:
             * You may assume that both strings contain only lowercase letters.
  
             * canConstruct("a", "b") -> false
             * canConstruct("aa", "ab") -> false
             * canConstruct("aa", "aab") -> true
             */

            var solution = new Solution();

            Console.WriteLine(solution.CanConstruct("a", "b") == false);
            Console.WriteLine(solution.CanConstruct("aa", "ab") == false);
            Console.WriteLine(solution.CanConstruct("aa", "aab") == true);
        }
    }

    public class Solution
    {
        // 使用陣列存放 26 個字母的計數
        // 改善效能

        private string _magazine;

        public bool CanConstruct(string ransomNote, string magazine)
        {
            _magazine = magazine;

            var findCount = 0;

            foreach (var ch in ransomNote)
            {
                if (HasNote(ch))
                {
                    findCount++;
                }
            }

            return findCount == ransomNote.Length;
        }

        private bool HasNote(char ch)
        {
            var isFind = false;

            foreach (var magazineChar in _magazine)
            {
                if (ch == magazineChar)
                {
                    isFind = true;
                    break;
                }
            }

            if (isFind)
            {
                var temp = _magazine.ToList();
                
                temp.Remove(ch);

                _magazine = new string(temp.ToArray());
            }

            return isFind;
        }
    }
}
