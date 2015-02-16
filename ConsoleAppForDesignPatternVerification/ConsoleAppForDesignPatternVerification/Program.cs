using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpDesignPatterns;

namespace ConsoleAppForDesignPatternVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            //strategy pattern
            Console.WriteLine("Strategy Pattern");
            Console.WriteLine("Use of the strategy pattern to determine which algorithm to use");
            Console.WriteLine("For both examples a 7 and a 1 will be passed to a strategy clients");
            Console.WriteLine("The clients take an algorithm  / class that is an extension if ICalculateInterface");
            cSharpDesignPatterns.Strategy.CalculateClient minusClient = new cSharpDesignPatterns.Strategy.CalculateClient(new Strategy.Minus());
            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());
            cSharpDesignPatterns.Strategy.CalculateClient plusClient =
            new cSharpDesignPatterns.Strategy.CalculateClient(new Strategy.Plus());
            Console.WriteLine("Plus: " + plusClient.Calculate(7, 1).ToString());


            Console.WriteLine("");
            
            //singleton pattern
            Console.WriteLine("Singleton Pattern");
            Console.WriteLine("Use of the singleton pattern to create a single instance of our object");
            Console.WriteLine("Within this example of the singleton is its own method to output its fav trait ");
            cSharpDesignPatterns.Singleton.Instance.FavoriteTrait(); 
            


            Console.ReadLine();

        }
    }
}
