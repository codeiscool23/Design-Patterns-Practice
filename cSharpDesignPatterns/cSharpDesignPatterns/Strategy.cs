using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDesignPatterns
{
    public class Strategy
    {
        /* This pattern enables an algorithm's behavior to be selected at runtime. The strategy pattern
            1)defines a family of algorithms,
            2)encapsulates each algorithm, and
            3)makes the algorithms interchangeable within that family.
         */

        //interface for which algorithm to use in the strategy
        public interface ICalculateInterface
        {
            //defin method
            int Calculate(int value1, int value2);
        }
         
        //strategy 1: minus
        public class Minus : ICalculateInterface
        {
            public int Calculate(int value1, int value2)
            {
                //define the logic 
                return value1 - value2;
            }
        }

        //strategy 2: plus
        public class Plus : ICalculateInterface
        {
            public int Calculate(int value1, int value2)
            {
                //define the logic 
                return value1 + value2;
            }
        }

        //strategy 3: multiply
        public class Multiply : ICalculateInterface
        {
            public int Calculate(int value1, int value2)
            {
                //define the logic 
                return value1 * value2;
            }
        }

        //strategy 4: divide
        public class Divide: ICalculateInterface
        {
            public int Calculate(int value1, int value2)
            {
                //define the logic 
                return value1 / value2;
            }
        }

        //class to be used as the client for the strategy
        public class CalculateClient
        {
            private ICalculateInterface calculateInterface;

            //constructor: assigns strategy to interface
            public CalculateClient(ICalculateInterface strategy)
            {
                this.calculateInterface = strategy;
            }

            //executes the strategy
            public int Calculate(int value1, int value2)
            {
                return calculateInterface.Calculate(value1, value2);

            }

        }

    }
    /* to implement you would  be able to do something like this:
     * CalculateClient minusClient = new CalculateClient(new Minus());
        Response.Write("<br />Minus: " + minusClient.Calculate(7, 1).ToString());
 
        CalculateClient plusClient = new CalculateClient(new Plus());
        Response.Write("<br />Plus: " + plusClient.Calculate(7, 1).ToString());
     * 
     */



}
