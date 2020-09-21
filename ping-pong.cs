using System;

class PingPong {
  static void Main() 
  {
    Console.WriteLine("Please enter any number of your choice.");
    string userString = Console.ReadLine();
    int userInput = int.Parse(userString);

    for (int i = 1; i <= userInput; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}