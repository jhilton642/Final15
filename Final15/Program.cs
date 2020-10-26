using System;

namespace Final15
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Program.SayHello("German");
            Console.WriteLine(x);
        }
        public static string SayHello(string language)
        {
            string translated ="";
            switch (language)
            {
                case "German":
                    translated = "Guten Tagge";
                    break;
                case "Dutch":
                    translated = "Gooie Morgen";
                        break;
                case "Spanish":
                    translated = "Hola";
                    break;
                case "French":
                    translated = "Bonjour";
                    break;
                case "Russian":
                    translated = "Здравствуйте";
                    break;
            }
            return translated;
        }
    }
}
