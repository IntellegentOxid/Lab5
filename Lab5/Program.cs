using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



using System;



namespace ProgrammingTools

{

    enum ProgrammingTool : byte

    {

        Chrome = 1,

        Firefox,

        Edge,

        Safari,

        VisualStudio = 10,

        IntelliJ,

        Eclipse,

        VisualStudioCode

    }



    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Programming Tools:");



            foreach (ProgrammingTool tool in Enum.GetValues(typeof(ProgrammingTool)))

            {

                Console.WriteLine("{0, 2} - {1}", (byte)tool, tool);

            }



            Console.WriteLine();

            Console.Write("Enter the numbers of your favorite programming tools separated by commas: ");



            string input = Console.ReadLine();

            string[] numbers = input.Split(',');



            Console.WriteLine("Your favorite programming tools:");



            foreach (string number in numbers)

            {

                if (byte.TryParse(number.Trim(), out byte toolNumber))

                {

                    if (Enum.IsDefined(typeof(ProgrammingTool), toolNumber))

                    {

                        ProgrammingTool tool = (ProgrammingTool)toolNumber;

                        Console.WriteLine("{0, 2} - {1}", toolNumber, tool);

                    }

                }

            }



            Console.WriteLine();

            Console.WriteLine("Author: Viktor Synenko");

            Console.WriteLine("Favorite browsers: Chrome, Firefox, Edge, Safari");

            Console.WriteLine("Favorite IDEs: Visual Studio, IntelliJ, Eclipse, Visual Studio Code");

            Console.ReadLine();

        }

    }

}