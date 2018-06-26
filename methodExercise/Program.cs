using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // first method called is the addMethod; which adds two integers.
            int firstNum = 0, secondNum = 0, finalAnswer;
            Console.WriteLine("What is a number to use in the add method? \n Press enter:");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What is a second number to use? \n Press enter:");
            secondNum = int.Parse(Console.ReadLine());

            finalAnswer = methodExercise.methods.addMethod(firstNum, secondNum);
            Console.WriteLine("Your answer is: \n" + finalAnswer + "\n Press Enter for the next method.");
            Console.ReadLine();

            // second method called is the multiplyMethod; which multiplies two integers.
            Console.WriteLine("Next, what is a number to use in the multiply method? \n Press enter:");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What is a second number to use? \n Press enter:");
            secondNum = int.Parse(Console.ReadLine());

            finalAnswer = methodExercise.methods.multiplyMethod(firstNum, secondNum);
            Console.WriteLine("Your answer is: \n" + finalAnswer + "\n Press Enter for the next method.");
            Console.ReadLine();

            // third method called is the divisionMethod; which divides two integers.
            Console.WriteLine("And finally, what is a number to use in the division method? \n Press enter:");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What is a second number to use? \n Press enter:");
            secondNum = int.Parse(Console.ReadLine());

            finalAnswer = methodExercise.methods.divisionMethod(firstNum, secondNum);
            Console.WriteLine("Your answer is: \n" + finalAnswer);
            Console.ReadLine();

        }
    }
}
