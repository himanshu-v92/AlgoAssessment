using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            //throw argument exception if the given word is empty
            if (string.IsNullOrEmpty(value)) throw new ArgumentException();

            //variable to store vowel count
            int count = 0;

            //changing given word to uppercase
            value = value.ToUpper();

            //looping through each character to check if it is vowel
            for (int i = 0; i < value.Length; i++)
            {                
                switch (value[i])
                {
                    //incrementing value of count if vowel is found
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        ++count;
                        break;
                }
            }

            //returning vowel count
            return count;
        }
    }
}
