using System;

namespace HomeTask12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void OneSpace(string str)
        {
            string[] arr = str.Split(' ');
            str = "";
            foreach (var item in arr)
            {
                if (item != "")
                {
                    str += item + " ";
                }
            }
            Console.WriteLine(str.TrimEnd());
        }

        static bool Check(string word)
        {
            bool check = false;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    a++;
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    b++;
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    c++;
                }
            }
            if (a != 0 && b != 0 && c != 0)
            {
                check = true;
                return check;
            }
            else
                return check;
        }

        static string FirstWord(string word)
        {
            string newWord = "";
            word = word.Trim();
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] != ' ')
                {
                    newWord += word[i];
                }
                else
                {
                    break;
                }
            }
            return newWord;
        }

        static bool UpperWord(string word)
        {
            int count = 0;
            string newWord = "";
            string[] arr;
            word = word.Trim();
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] != ' ')
                {
                    newWord += word[i];
                }
                else if (word[i] == ' ' && word[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    count++;
                    newWord += " ";
                }
                if (count == 2)
                {
                    break;
                }
            }
            if (count != 2)
            {
                return false;
            }
            arr = newWord.Split(" ");
            return char.IsUpper(arr[0][0]) && char.IsUpper(arr[1][0]);
        }

        static void AddNumber(ref int[] numbers, int number)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            int j = 0;
            foreach (var item in numbers)
            {
                newNumbers[j++] = item;
            }
            newNumbers[numbers.Length] = number;
            numbers = newNumbers;
        }
    }
}
