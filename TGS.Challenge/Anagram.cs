using System;
using System.Linq;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            //throw argument exception if any of the given word is empty
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)) throw new ArgumentException();

            //removing punctuations and spaces
            word1 = new string(word1.Where(c => !char.IsPunctuation(c)).ToArray()).Replace(" ", "");
            word2 = new string(word2.Where(c => !char.IsPunctuation(c)).ToArray()).Replace(" ", "");

            //if length of both the words are not equal then they are not anagrams
            if (word1.Length != word2.Length) return false;

            //cnverting each word into character array
            char[] word1Arr = word1.ToLower().ToCharArray();
            char[] word2Arr = word2.ToLower().ToCharArray();

            //integer array to store occurrence of each character
            //length is defined 26 to store occurrence of character 'a' at position 0, occurrence of character 'b' at position 1 and so on
            int[] indexCharCount = new int[26];

            for (int i = 0; i < word1Arr.Length; i++)
            {
                //incrementing the value at position calculated from character ASCII value from word1 and
                //decrementing the value at position calculated from character ASCII value from word2
                //this will make the value 0 if the character in word1 occurs in word2
                indexCharCount[word1Arr[i] - 97]++;
                indexCharCount[word2Arr[i] - 97]--;
            }

            //checking if any position value is not 0
            if (indexCharCount.Any(r => r != 0)) return false;

            return true;
        }
    }
}
