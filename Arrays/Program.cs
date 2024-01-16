namespace Arrays
{
    internal class Program
    {
        // Checks if a string is a palindrome
        public static bool palindrome( string s)
        {
            char[] chars = s.ToCharArray();
            int p1 = 0;
            int p2 = chars.Length-1;
            while (p1 <= p2) { 
                if(chars[p1] != chars[p2] ) { 
                return false;
                }
                p1++;
                p2--;
            }
            return true;
        }

        // Reverses array of integers using a stack
        public static int[] reverseArray(int[] array )
        {
            Stack<int> stack = new Stack<int>();
            foreach(int i in array )
            {
                stack.Push( i );
            }
            for(int i  = 0; i < array.Length; i++ )
            {
                array[i] = stack.Pop();
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");
            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Count());
            // Using the .Append() .Prepend() methods and converting it back to a string array
            numbers = numbers.Append<int>(10).ToArray();
            numbers = numbers.Prepend<int>(0).ToArray();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($"{numbers[x]}, ");
            }
            Console.WriteLine("\nWorking with string array");
            string[] dayArray = new string[] {"Mon","Tue"};
            dayArray = dayArray.Append("Wed").ToArray();
            // Display values
            foreach(var item in dayArray)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\nWorking with objects");
            object[] obj = new[] {"12","2.5","8","monday","tuesday"};
            foreach( var item in obj)
            {
                Console.Write(item + " , ");
            }
            // Exercise
            Console.WriteLine("\n---------------");
            object[] objVar = {12, 2.5, 8,5.5,"monday","tuesday"};
            double sum = 0;
            foreach( var item in objVar)
            {
                Console.Write(item + " , ");
                if (item.GetType() == typeof(double))
                {
                    sum+= (double)item;
                }else if(item.GetType() == typeof(int))
                {
                    sum+= (int)item;
                }
            }
            Console.WriteLine($"\nSum of ints and doubles is: {sum}");
            Console.WriteLine("---------------");
            bool valid = false;
            string response;
            int resp;
            char[] chars;
            int sumInt = 0;
            while(!valid)
            {
                Console.Write("Enter an integer number: ");
                response = Console.ReadLine();
                try
                {
                    resp = Convert.ToInt32(response);
                }
                catch
                {
                    Console.WriteLine("\nInvalid number, Type and integer");
                    continue;
                }
                Console.WriteLine(resp);
                if(resp.GetType() == typeof(int))
                {
                    valid = true;
                    chars = response.ToCharArray();
                    foreach( char c in chars)
                    {
                        Console.Write(c + ", ");
                        sumInt += (int)char.GetNumericValue(c);
                    }
                }

            }
            Console.WriteLine($"\nSum of ints is: {sumInt}");
            Console.WriteLine("---------------");
            Console.Write("Enter a string to check its a palindrome: ");
            string p = Console.ReadLine();
            Console.WriteLine(palindrome(p));
            Console.WriteLine("---------------");
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach( int i in test)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine("\n");
            test = reverseArray(test);
            foreach (int i in test)
            {
                Console.Write(i + ", ");
            }

            Console.ReadLine();
        }
    }
}
