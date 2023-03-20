namespace CircleDrawing;
class Program
{
    static void Main(string[] args)
    {
        int radius;
        bool result;
        Console.Write("Please enter the radius : ");
        do
        {
            result = int.TryParse(Console.ReadLine(), out radius);
            if(result == false || radius <= 0)
                Console.Write("Please enter the positive number : ");

        }while(result == false || radius <= 0);

        if(radius == 1)
            Console.WriteLine("*");
        else if(radius == 2)
        {
           Console.WriteLine(" * ");
           Console.WriteLine("***");
           Console.WriteLine(" * ");
        }
        else if(radius == 3)
        {
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("   ***   ");
        }
        else
        {
        for (double i = -radius; i <= radius; i ++)
            {
                for (double j = -radius; j <= radius; j += 0.5)
                {
                    if ( (i * i) + (j * j) >= radius * radius)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }        
    }
}
