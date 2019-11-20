using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wex_brazil_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment for debug
            //args = new[] { "2", "5"};
            try
            {
                var arg = args[0].Length == 0 ? string.Empty : args[0];
                //CaseInsesitive
                var command = string.IsNullOrWhiteSpace(arg) ? string.Empty : arg.ToLower();

                switch (command)
                {
                    case "?":
                    case "help":
                        ImprimirHelp();
                        break;
                    case "1":
                        var param1 = string.Format("{0}", args[1]);
                        DividedBy3(param1);
                        break;
                    case "2":
                        var param2 = string.Format("{0}", args[1]);
                        DrawReverseTree(param2);
                        break;
                    default:
                        Console.Write("Comando não reconhecido ou parâmetro inválido. Digite help para acessar ajuda.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Um ou mais parâmetros foram informados incorretamente.");
            }



        }



        private static void DividedBy3(string number)
        {
            Console.WriteLine("These are numbers divided by 3 and contains 5");

            if (string.IsNullOrWhiteSpace(number)) throw new Exception();
            int value = int.Parse(number);

            for (int num = 0; num <= value; num++)
            {

                if (num % 3 == 0)
                {
                    var ifcontains5 = num.ToString().Contains("5") == true ? "Dinha" : "";
                    Console.WriteLine(num + $" - Cira {ifcontains5}");

                }



            }

        }

        private static void DrawReverseTree(string level)
        {
            Console.WriteLine("That's a draw reverse tree");

            if (string.IsNullOrWhiteSpace(level)) throw new Exception();
            int value = int.Parse(level);
            var space = "";


            for (int i = value; i >= 0; i--)
            {


                for (int l = 0; l < (value - i); l++)
                {
                    space += " ";

                }

                int j = 0;
                while (j != i)
                {
                    if (j == 0)
                        Console.Write(space);

                    Console.Write(" *");

                    j++;
                }

                Console.WriteLine();
                space = "";
            }


        }

        private static void ImprimirHelp()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WEX Brasil, by Valnei Filho v_marinpietri@yahoo.com.br");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Write("Sintax: ");
            Console.WriteLine("wex_brazil_test {command} {parameters}");
            Console.WriteLine("");
            Console.WriteLine("Commands suported.");
            Console.Write(
                "-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("?                - Help ");
            Console.WriteLine("1 20             - Exercise 1, 20 a parameter, and press enter to search numbers divide by 3");
            Console.WriteLine("2 5              - Exercise 2, 5 a parameter (level of tree),and press enter to draw a reverse tree.");
            Console.WriteLine(
        "-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Example to access the first exercise");
            Console.WriteLine(@"D:wex_brazil_test\bin\Debug\wex_brazil_test 1 20");
        
            Console.Write("");
            Console.WriteLine(""); Console.WriteLine(
          "-----------------------------------------------------------------------------------------------------------");
        }




    }
}
