using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Question 1

        // Console.WriteLine("Enter a number: ");
        // int number = int.Parse(Console.ReadLine()!);
        //
        // // Check if the number can be divided by 3 and 4
        // string message = number % 4 == 0 && number % 3 == 0 ? "Yes" : "No";
        // Console.WriteLine(message);

        #endregion

        #region Question 2

        // Console.WriteLine("Enter a number: ");
        // int number = int.Parse(Console.ReadLine()!);
        //
        // // Check if the number negative or positive
        // string message = number < 0  ? "Negative" : "Positive";
        // Console.WriteLine(message);

        #endregion

        #region Question 3

        // int MAX_NUMBER = 0;
        // int MIN_NUMBER = 0;
        //
        // Console.WriteLine("Enter the first number: ");
        // int firstNumber = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter the second number: ");
        // int secondNumber = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter the third number: ");
        // int thirdNumber = int.Parse(Console.ReadLine());
        //
        // // Check the Max number
        // if (firstNumber > secondNumber && firstNumber > thirdNumber)
        // {
        //     MAX_NUMBER = firstNumber;
        // } else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        // {
        //     MAX_NUMBER = secondNumber;
        // } else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        // {
        //     MAX_NUMBER = thirdNumber;
        // }
        //
        // // Check the Min number
        // if (firstNumber < secondNumber && firstNumber < thirdNumber)
        // {
        //     MIN_NUMBER = firstNumber;
        // }else if (secondNumber < firstNumber && secondNumber < thirdNumber)
        // {
        //     MIN_NUMBER = secondNumber;
        // } else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
        // {
        //     MIN_NUMBER = thirdNumber;
        // }
        //
        // Console.WriteLine($"Max element is {MAX_NUMBER}");
        // Console.WriteLine($"Min element is {MIN_NUMBER}");

        #endregion

        #region Question 4

        // Console.WriteLine("Enter a number: ");
        // int number = int.Parse(Console.ReadLine()!);
        //
        // // Check if the number even or odd
        // string message = number % 2 == 0 ? "Number is Even" : "Number is Odd";
        // Console.WriteLine(message);

        #endregion

        #region Question 5

        // char letter = char.Parse(Console.ReadLine());
        //
        // // handle the case-sensitive
        // char lowercaseLetter = char.ToLower(letter);
        //
        // if (lowercaseLetter == 'a'  || lowercaseLetter == 'e'  || lowercaseLetter == 'i' ||
        //     lowercaseLetter == 'o'  || lowercaseLetter == 'u' )
        // {
        //     Console.WriteLine("Vowel !");
        // }else
        // {
        //     Console.WriteLine("Consonant !");   
        // }

        #endregion

        #region Question 6

        // int TOTAL = 0;
        // double AVG = 0;
        // double PERCENTAGE = 0;
        //
        // Console.WriteLine("Enter Marks of five subjects: ");
        // int subj1 = int.Parse(Console.ReadLine());
        // int subj2 = int.Parse(Console.ReadLine());
        // int subj3 = int.Parse(Console.ReadLine());
        // int subj4 = int.Parse(Console.ReadLine());
        // int subj5 = int.Parse(Console.ReadLine());
        //
        //
        // TOTAL = subj1 + subj2 + subj3 + subj4 + subj5;
        // AVG = TOTAL / 5;
        // PERCENTAGE = (TOTAL / 500.0) * 100;
        //
        // Console.WriteLine($"Total Marks : {TOTAL}");
        // Console.WriteLine($"Average Marks : {AVG}");
        // Console.WriteLine($"Percent  : {PERCENTAGE}%");

        #endregion

        #region Question 7

        Console.WriteLine("Enter the number of month");
        int month = Convert.ToInt32(Console.ReadLine());

        if (month is 1 or 3 or 5 or 7 or 8 or 10 or 12)
        {
            Console.WriteLine($"Days in Month: 31");
        }else if (month is 4 or 6 or 9 or 11)
        {
            Console.WriteLine($"Days in Month: 30");
        } else if (month == 2)
        {
            Console.WriteLine($"Days in Month: 28");
        }

    #endregion
    }
}