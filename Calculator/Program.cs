namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {

      System.Console.WriteLine("Welcome to our basic calculator!");
      var stay = true;

      do {

        System.Console.WriteLine("Menu");
        System.Console.WriteLine("Press 1 for Addition");
        System.Console.WriteLine("Press 2 for Subtraction");
        System.Console.WriteLine("Press 3 for Multiplication");
        System.Console.WriteLine("Press 4 for Division");
        System.Console.WriteLine("Press 5 to exit");

        var input = System.Console.ReadLine();

        switch (input)
        {

          case "1":
            //var input1 = (double)System.Console.ReadLine(); //explicit casting with exception on fail
            //var input2 = System.Console.ReadLine() as double; //explicit casting with null on fail

            var input1 = double.Parse(System.Console.ReadLine()); //explicit parsing with 0 on fail
            double input2;
            double.TryParse(System.Console.ReadLine(), out input2); //explicit parsing with exception on fail

            Add(input1, input2);

            break;

          case "2":

            var input3 = double.Parse(System.Console.ReadLine()); 
            double input4;
            double.TryParse(System.Console.ReadLine(), out input4);

            Subtract(input3, input4);

            break;

          case "3":

            var input5 = double.Parse(System.Console.ReadLine()); 
            double input6;
            double.TryParse(System.Console.ReadLine(), out input6);

            Multiply(input5, input6);

            break;

          case "4":

            var input7 = double.Parse(System.Console.ReadLine()); 
            double input8;
            double.TryParse(System.Console.ReadLine(), out input8);
            Divide(input7, input8); //handle divide by 0 (loop/throw an exception), division by 0 returns infinity

            break;

          case "5":
          
            stay = false;
            break;

        }

      } while (stay);

    }

    static void Add(double operand1, double operand2)
    {

      System.Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");

    }

    static void Subtract(double operand1, double operand2){

      System.Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");

    }

    static void Multiply(double operand1, double operand2){

      System.Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");

    }

    static void Divide(double operand1, double operand2){

      System.Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");

    }

  }
}
