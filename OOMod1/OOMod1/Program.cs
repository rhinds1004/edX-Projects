using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("kitchen", "brand", "DM100");
           // myMachine.Location = "kitchen";
           // myMachine._model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();

            Console.WriteLine(Math.Pow(2.0, 9.3));

        }
    }
}
