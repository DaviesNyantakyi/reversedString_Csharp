using System;
using System.Runtime.InteropServices;

class MyApp
{

    static class ReversedString
    {   


        static void Main()
        {
          //Ask user for input
          Console.Write("Write a text:");
          string? text = Console.ReadLine();

          // Check if input in not empty
          if (!String.IsNullOrEmpty(text))
          {
              string reversedText =  reverseString(text: text);
              Console.WriteLine(reversedText);

          }
          else
          {
              Console.WriteLine("User input is null");
          }
        }

        static string reverseString(string text)
        {
            // Reverse the string
            char[] charArry = text.ToCharArray();
            Array.Reverse(charArry);
            return new string(charArry);
        }
    }
}
