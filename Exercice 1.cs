class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Multiplication Tables");

        for (int i = 2; i <= 12; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0}*{1}={2}", i, j, i*j);
            }
        }

        Console.ReadLine(); // <-- Both loops now complete
    }
}

    static void ex1b()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("\nTable of {0}", i);
                    for (int j = 0; j <= 10; j++)
                    {
                        if (j * i % 2 == 1)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                }
            }

    private static int AskUserForParameter()
            {
                Console.WriteLine("Please write a number and press enter :");
                int.TryParse(Console.ReadLine(), out var result);
                return result;
            }

            static void ex1c()
            {
                int i = AskUserForParameter();
                if (i <= 1000)
                {
                    Console.WriteLine("\nTable of {0}", i);
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                }
                else
                    Console.WriteLine("N too big");
            
            }

    static void ex2a()
        {
            int n = AskUserForParameter();
            int i = 2;
            if (n < 1000)
            {
                while(i <n/2)
                {
                    if(n%i==0)
                    {
                        Console.WriteLine($"{n} is not prime (divisible by {i}).");
                        return;
                    }
                    i+=1+Convert.ToInt32(i%2!=0);
                }
                Console.WriteLine($"{n} is prime.");
                return;

            }
            Console.WriteLine("Number N too big");
            
        }
    
    static void ex2b()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 2;
            int n = AskUserForParameter();
            if (n < 1000)
            {
                while(i <= n)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    i+=1;
                }
                Console.WriteLine($" F({n}) = {c}");
                return;
            }
            Console.WriteLine("Number N too big");
        }

     static void ex2c()
        {
            int j = 1;
            int n = AskUserForParameter();
            for (int i = 1; i <= n; i++)
            {
                j*=i;
            }
            Console.WriteLine($"!{n} = {j}");
        }

// if we try to calculate 420000!, the computer will die because of the memory it needs, and the calculation power it needs.
// A recursive function is a function that call herself in the function.

    static void ex3()
        {
            for(int i = -3;i<=3;i++)
                try
                {
                    Console.WriteLine($"{i}: {10/PowerFunction(i)}");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{i} didn't work.");
                }

        } 

    static void ex4()
        {
            int[] dimensions = AskUserFor2Parameters();
            int M = dimensions[0];
            int N = dimensions[1];
            Console.WriteLine($"{M}x{N}\n");
            if (M >= 1 && M <= 1000 && N >= 1 && N <= 1000)
            {
                Console.Write("0");
                for (int i = 0; i <M; i++)
                {
                    Console.Write("_");
                }
                Console.Write("0\n");
                for (int j = 0; j < N; j++)
                {
                    Console.Write("|");
                    for (int i = 0; i < M; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|\n");
                }
                Console.Write("0");
                for (int i = 0; i < M; i++)
                {
                    Console.Write("_");
                }
                Console.Write("0\n");
                return;
            }
            Console.WriteLine("Wrong dimensions.");
        }
// M et N sont les nombres de tirets dans le rectangle, nous avons décidé de ne pas comptrer les 0 dans M et N.
// Dans notre cas, par exemple, un rectangle (1,1) est représené par :


