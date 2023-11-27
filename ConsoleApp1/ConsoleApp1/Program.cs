// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        method2();
    }

    static void method2()
    {
        Console.WriteLine("Hello");
        // print that "today is a good day" 
        Console.WriteLine("Today is a good day");
        // create a variable called "name" and assign it to your name
        string name = "Sara";
        // print "Hello <name>"
        Console.WriteLine("Hello " + name); 

        // create int, double, and string variables, assigne values tgo them and print them on the console
        // also put comments on each line to explain what the code is doing

        int num = 5;
        double num2 = 5.5;
        string word = "Hello";
        Console.WriteLine(num);
        Console.WriteLine(num2);
        Console.WriteLine(word);
        Console.WriteLine(
            "Hello, World!"
                   );

      // type conversion from int to double
      int num3 = 5; 
        double num4 = num3;
        Console.WriteLine(num4);
        // type conversion from byte to int
            byte num5 = 5;
            
        int num6 = num5;
        Console.WriteLine(num6);

        // read data from file and print it using streamreader, can you print the data in reverse order?

        string path = @"C:\Users\user\Desktop\test.txt";
        StreamReader sr = new StreamReader(path);
        string line = sr.ReadLine();
        List<string> lines = new List<string>();

        // add variable to read all lines

        while (line != null)
        {
               Console.WriteLine(line);
            line = sr.ReadLine();
            lines.Add(line);

        }
        while (line != null)
        {
            lines.Add(line);
            line = sr.ReadLine();
        }

        sr.Close();

        lines.Reverse();

        foreach (string reversedLine in lines)
        {
            Console.WriteLine(reversedLine);
        }




            

    }
}
