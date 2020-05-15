using System;
using System.Collections.Generic;
using System.Linq;

namespace _014_Implement_Trie_Prefix_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a trie with insert, search, and startsWith methods.
  
             * Example:
             * Trie trie = new Trie();
             * trie.insert("apple");
             * trie.search("apple");   // returns true
             * trie.search("app");     // returns false
             * trie.startsWith("app"); // returns true
             * trie.insert("app");   
             * trie.search("app");     // returns true

             * Note:
             *   You may assume that all inputs are consist of lowercase letters a-z.
             *   All inputs are guaranteed to be non-empty strings.
             */

            Trie trie = new Trie();
            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple") == true);   // returns true
            Console.WriteLine(trie.Search("app") == false);     // returns false
            Console.WriteLine(trie.StartsWith("app") == true); // returns true
            trie.Insert("app");
            Console.WriteLine(trie.Search("app") == true);     // returns true
        }
    }

    public class Trie
    {
        private HashSet<string> _datas;

        /** Initialize your data structure here. */
        public Trie()
        {
            _datas = new HashSet<string>();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            _datas.Add(word);
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            return _datas.Any(it => it == word);
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            return _datas.Count(it => it.StartsWith(prefix)) > 0;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
