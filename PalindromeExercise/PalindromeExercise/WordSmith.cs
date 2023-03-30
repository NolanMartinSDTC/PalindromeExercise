using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
        public bool IsAPalindrome(string word)
        {
            //throw new NotImplementedException();

            string revWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                revWord += word[i];
            }

            Console.WriteLine(revWord);
            return ((word == revWord) ? true : false);
        }

    }
}

