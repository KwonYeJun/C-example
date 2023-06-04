using System;

class Program
{
  static void Main()
  {
    int number = 10, test = 0;
    string name = "yejun";
    Console.WriteLine(number + name);
    if (number == 10)
    {
      Console.WriteLine('일');
      Console.WriteLine("일치합니다.");
      for (int i = 0; i < number; i++)
      {
        test += 3;
      }
      Console.Write(test+"\n");
      Console.Write("함수를 불러 add한 값 : "+ AddTest(test, number)
);

    }
    else
    {
      Console.Write("아닌경우");
    }

  }

  static int AddTest(int a, int b)
  {
    return a + b;
  }
}