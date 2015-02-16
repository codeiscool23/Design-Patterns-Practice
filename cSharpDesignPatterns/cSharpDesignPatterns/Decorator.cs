using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDesignPatterns
{
    public class Decorator
    {
        public interface IComponent
        {
            string Operation();
        }

        public class Component : IComponent
        {
            public string Operation()
            {
                return "I am walking ";
            }
        }

        public class DecoratorA : IComponent
        {
            private IComponent component;

            public DecoratorA(IComponent c)
            {
                component = c;
            }

            public string Operation()
            {
                string s = component.Operation()
                    ;
                s += "and listening to music on Spotify ";
                return s;
            }

        }

        public class DecoratorB : IComponent
        {
            private IComponent component;

            public string addedState = "past a coffee shop ";

            public DecoratorB(IComponent c)
            {
                component = c;

            }

            public string Operation()
            {
                string s = component.Operation();
                s += "and on my way to work ";
                return s;
            }

            public string AddedBehavior()
            {
                return "and bought myself and an Americano ";
            }
        }


        //public abstract class BakeryComponent
            //{
            //    public abstract string GetName();
            //    public abstract double GetPrice();

            //}

            //class CakeBase : BakeryComponent
            //{
            //    private string m_Name = "CakeBase";
            //    private double m_Price = 200.0;

            //    public override string GetName()
            //    {
            //        return m_Name;
            //    }

            //    public override double GetPrice()
            //    {
            //        return m_Price;
            //    }
            //}

            //class PastryBase : BakeryComponent
            //{
            //    private string m_Name = "Pastry Base";
            //    private double m_Price = 20.0;

            //    public override string GetName()
            //    {
            //        return m_Name;
            //    }

            //    public override double GetPrice()
            //    {
            //        return m_Price;
            //    }
            //}

            //public abstract class Decorator : BakeryComponent
            //{
            //    BakeryComponent m_BaseComponent = null;

            //    protected string m_Name = "Undefined Decorator";
            //    protected double m_Price = 0.0;

            //    Decorator(BakeryComponent baseComponent)
            //    {
            //        m_BaseComponent = baseComponent;
            //    }

            //    #region BakeryComponent Members

            //    string BakeryComponent.GetName()
            //    {
            //        return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
            //    }

            //    double BakeryComponent.GetPrice()
            //    {
            //        return m_Price + m_BaseComponent.GetPrice();
            //    }
            //    #endregion
            //}
            //class ArtificialScentDecorator : Decorator
            //{
            //    public ArtificialScentDecorator(BakeryComponent baseComponent)
            //        : base(baseComponent)
            //    {
            //        this.m_Name = "Artificial Scent";
            //        this.m_Price = 3.0;
            //    }
            //}





        }
}
