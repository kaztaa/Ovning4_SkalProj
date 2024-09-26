using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            // the n:th even number
            //int nth = 5;

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. RecursiveEven"
                    + "\n6. fibonacciCalc"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        Console.WriteLine(RecursiveEven(10));
                        break;
                    case '6':
                        Console.WriteLine(fibonacciCalc(8));
                        break;
                    case '7':
                        Console.WriteLine(IterativeEven(10));
                        break;
                    case '8':
                        Console.WriteLine(fibonacciCalc(1));
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 8)");
                        break;
                }
            }
        }





        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine("+ add to list, - remove from list, Q quit to menu:");
                string input = Console.ReadLine();

                // Check if input length is 0
                if (input.Length == 0) 
                    continue;

                
                char nav = input[0];

                // Removing empty space in string
                string value = input.Substring(1).Trim();

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Adding: {value}");

                        break;

                    case '-':
                        if (theList.Remove(value))
                            Console.WriteLine($"Removing: {value}");

                        else
                            Console.WriteLine($"Can't find {value} in list, try again");

                        break;
                    default:
                        Console.WriteLine("Only + or - or Q quit to menu");

                        break;
                }

                // Write list current capacity status
                Console.WriteLine($"Count of items: {theList.Count}");
                Console.WriteLine($"Capacity of list: {theList.Capacity}");

                // Exit loop if user hits e
                if (input.ToLower() == "q")
                    break;




                // Svar på frågor:
                // 2: När nyttjad kapacitet överstiger sin gräns expanderar den.
                // 3: Kapaciteten dubblas för varje gång.
                // 4: Den underliggande arrayen dubbleras vid varje utökning / kopiering av sig själv
                // 5: Nej, kapaciteten förblir densamma.
                // 6: Vet man hur många items är en array bra, vet man inte är lista enklare att hantera.


            }
        }


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> theQueue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("E - for Enqueueing or D for Dequeueing or Q quit to menu: ");
                string input = Console.ReadLine();

                // Check if input length is 0
                if (input.Length == 0)
                    continue;


                char nav = input[0];

                // Removing empty space in string
                string value = input.Substring(1).Trim();
                switch (nav)
                {
                    case 'e':
                        {
                            Console.WriteLine("Enter somting to add to queue: ");
                            string qInput = Console.ReadLine();
                            Console.WriteLine($"Adding {qInput} to queue");

                            theQueue.Enqueue(qInput);
                            break;
                        }
                    case 'd': 
                        {
                            if (theQueue.Count > 0)
                                Console.WriteLine($"Dequeued '{theQueue.Dequeue()}' from queue");
                            else
                                Console.WriteLine("Queue is empty");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Only use D or E or Q quit to menu");
                            break;
                        }
                }
                // Exit loop if user hits e
                if (input.ToLower() == "q")
                    break;

            }
        }
        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            // Fråga 1 - Första personen kan få vänta väldigt länge, om kön aldrig blir tom blir det aldrig denns tur..
        
            Stack<string> stack = new Stack<string>();
            while (true)
            {
                Console.WriteLine("Enter P for push or O for Pop, Q quit to menu: ");
                string input = Console.ReadLine();

                // Check if input length is 0
                if (input.Length == 0)
                    continue;
                else if (input.ToLower() == "q") 
                    break; 
                


                char nav = input[0];

                // Removing empty space in string
                string value = input.Substring(1).Trim();
                switch (nav)
                {
                    case 'p':
                        {
                            Console.WriteLine("Enter somting to add to stack: ");
                            string qInput = Console.ReadLine();
                            Console.WriteLine($"Adding {qInput} to stack");

                            stack.Push(qInput);
                            break;
                        }
                    case 'o':
                        {
                            if (stack.Count > 0)
                                Console.WriteLine($"Popping '{stack.Pop()}' from stack");
                            else
                                Console.WriteLine("Stack is empty");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Only use Push or Pop or Q quit to menu");
                            break;
                        }
                }


            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            // Starting with a new stack of chars
            Stack<char> charStack = new Stack<char>();

            Console.WriteLine("Enter a string to check paranthesis: ");
            string stringInput = Console.ReadLine();

            for (int i = 0; i < stringInput.Length; i++)
            {

                // Check if char is opening bracket, if so push to stack
                if (stringInput[i] == '(' || stringInput[i] == '[' || stringInput[i] == '{')
                {
                    charStack.Push(stringInput[i]);
                }
                else
                {
                    // Check if char is closing bracket, if stack is and top item is a matching bracket
                    if (charStack.Count > 0 &&
                        ((charStack.Peek() == '(' && stringInput[i] == ')') ||
                         (charStack.Peek() == '[' && stringInput[i] == ']') ||
                         (charStack.Peek() == '{' && stringInput[i] == '}')))
                    {
                        charStack.Pop();

                    }
                } 
            }


            // If stack is empty the stack is empty, then paranthesis is ok
            if (charStack.Count == 0)
                Console.WriteLine("Nothing left in the stack - paranthesis is correct!");
            else
                Console.WriteLine("Stack is not empty, paranthesis is not corret!");

        }

        static int RecursiveEven(int n)
        {
            if (n == 1)
                return 2;

            return 2 + RecursiveEven(n - 1);

        }

        static int fibonacciCalc(int n)
        {
            if (n <= 1)
                return n;

            return fibonacciCalc(n - 1) + fibonacciCalc(n - 2);


        }


    }
}

