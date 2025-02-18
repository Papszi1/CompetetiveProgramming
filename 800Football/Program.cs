namespace Foca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string filePath = "input.txt";

            string contect = File.ReadAllText(filePath);

            string[] sorok = contect.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            
            int k = int.Parse(sorok[0]);
            Console.WriteLine(k);

            for (int i = 1; i < sorok.Length; i+=2)
            {
                string[] elmenet = sorok[i].Split(' ');
                string[] visszajov = sorok[i+1].Split(' ');

                int a = int.Parse(elmenet[0]);
                int b = int.Parse(elmenet[1]);
                int c = int.Parse(visszajov[0]);
                int d = int.Parse(visszajov[1]);

                Console.WriteLine(a +" "+ b+ " " + c+" " + d);
                bool joe = vane(a, b, c, d);
                Console.WriteLine(joe);
            }
            bool vane(int a, int b, int c, int d)
            {
                
                if (((a - b) * (c - d)) < 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}