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
            Console.WriteLine("Within this example of the singleton is its own method to output its fav trait: ");
            cSharpDesignPatterns.Singleton.Instance.FavoriteTrait();

            Console.WriteLine("");

            //decorator pattern
            Console.WriteLine("Decorator Pattern");
            Console.WriteLine("Implement any methods in the interface, changing the intiial behavior of the component");
            Console.WriteLine("add a new state and behavior");
            Console.WriteLine("Access any public members via the opject passed at construction");
            cSharpDesignPatterns.Decorator.Component c = new Decorator.Component();
            Console.WriteLine("1. Basic Component: " + c.Operation());
            Console.WriteLine("2. A-decorated: " + new Decorator.DecoratorA(c).Operation());
            Console.WriteLine("3. B-decorated: " + new Decorator.DecoratorB(c).Operation());
            Console.WriteLine("4. B-A decorated: " + new Decorator.DecoratorB(new Decorator.DecoratorA(c)).Operation());
            Decorator.DecoratorB b = new Decorator.DecoratorB(new Decorator.Component());
            //this decorators is showing a new state and new behavior for as part of decorator b
            Console.WriteLine("5. A-B decorated: " + new Decorator.DecoratorA(b).Operation() + b.addedState + b.AddedBehavior());


            Console.WriteLine("");

            //FactoryMethod pattern
            Console.WriteLine("FactoryMethod Pattern");
            Console.WriteLine("Factory pattern deals with the instantiation of object without exposing the instantiation logic. ");
            Console.WriteLine("In other words, a Factory is actually a creator of objects which have common interface");
            cSharpDesignPatterns.FactoryMethod fmFactoryMethod = new FactoryMethod();
           var person = fmFactoryMethod.GetPeople(PeopleType.Rural);
           Console.WriteLine("this person identifies as a: " + person.GetName());


           Console.WriteLine("");

           //decorator pattern
           Console.WriteLine("Observer Pattern");
               cSharpDesignPatterns.Observer.Subject subject = new Observer.Subject();
            cSharpDesignPatterns.Observer.Observerr test1 = new Observer.Observerr(subject,"Center", "\t\t");
            cSharpDesignPatterns.Observer.Observerr test2 = new Observer.Observerr(subject, "Right", "\t\t\t\t");
            subject.Go();

            Console.ReadLine();
        }
    }
}
