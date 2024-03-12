using System;
namespace Practices
{
	public class Stacks1
	{
		public Stacks1()
		{
            // Stacks Data Structures



            Stack<string> stack1 = new Stack<string>();

            //Pushing

            stack1.Push("Jhon");
            stack1.Push("Kate");
            stack1.Push("Edward");
            stack1.Push("Roxy");


            // Iterating and popping

            while (stack1.Count != 0)
            {

                Console.WriteLine(stack1.Pop());
            }


        }
    }
}

