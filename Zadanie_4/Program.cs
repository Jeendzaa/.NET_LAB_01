namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();
            
            if(!Directory.Exists(directory))
            {
                Console.WriteLine("Katalog nie isteniej");
                return;
            }

            Console.WriteLine("Zawartość katalogu: ");
            try
            {
                foreach(var dir in Directory.GetDirectories(directory))
                {
                    Console.WriteLine($"[FOLDER] {Path.GetFileName(dir)}");
                }
                
                foreach(var file in Directory.GetFiles(directory))
                {
                    Console.WriteLine($"[PLIK] {Path.GetFileName(file)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }
        }
    }
}
