namespace Delegate
{
    public class Program 
    {
        public static Func<int, bool> Tubmi { get; private set; }

        static void Main(string[] args)
        {
            Methods methods = new Methods();

            // Func delegate

            Func<int, int> Sum = methods.Sum;

            int val1 =  Sum(23);
            Console.WriteLine("N sonigacha bolgan sonlar yigi'indisi: " + val1);

            // Action delegate

            Action<string> printInfo = methods.PrintInfo;

            printInfo("Abdusalomov Bahriddin");

            // Predicat delegate
 
            Predicate<int> Istub = methods.Tubmi;

            bool val2 = Istub(23);
            Console.WriteLine("N soni tubmi: "  + val2);

        }

      
    }
}