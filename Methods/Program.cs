namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] org = { 1, 2, 5, 3, 4, 5, 7, 8, 9, 10, };
            Demo.PrintEven(org);


        }
    }

    // Method Syntax(simple form)
    // <AccessModifer> <DataType>/void MithodName (<parameter List>)
    //{
    //     series of statement
    //}
    public class Demo
    {
        public static void PrintEven(int[] original)
        {
            foreach (var item in original)
            {
                if (IsEven(item))
                {
                    Console.WriteLine($"{item} is even");
                }
            }
            bool IsEven(int x) => x % 2 == 0;
        }
        
    }
}