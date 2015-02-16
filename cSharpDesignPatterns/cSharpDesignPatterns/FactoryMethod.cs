using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDesignPatterns
{
    //these are the classes and enum that the factorymethod will use to create its return objects
    public interface IPeople
    {
        string GetName();
    }

    public class Villagers : IPeople
    {
        public string GetName()
        {
            return "Village Person";
        }
    }

    public class CityDweller : IPeople
    {
        public string GetName()
        {
            return "City Person";
        }
    }

    public class Suburbanite : IPeople
    {
        public string GetName()
        {
            return "Suburan Person";
        }
    }

    public enum PeopleType
    {
        Rural,
        Urban,
        Suburban
    }
    //Factory pattern deals with the instantiation of object without
    //exposing the instantiation logic. In other words, a Factory is actually 
    //a creator of objects which have common interface.
    public class FactoryMethod
    {
        public IPeople GetPeople(PeopleType type)
        {
            IPeople people = null;
            switch (type)
            {
                case PeopleType.Rural:
                    people = new Villagers();
                    break;
                case PeopleType.Urban:
                    people = new CityDweller();
                    break;
                case PeopleType.Suburban:
                    people = new Suburbanite();
                    break;
            }
            return people;
        }
    }
    
}
