namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Question 1

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        // Check if the number can be divided by 3 and 4
        string message = number % 4 == 0 && number % 3 == 0 ? "Yes" : "No";
        Console.WriteLine(message);

        #endregion
    }
}