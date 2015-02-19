using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cSharpDesignPatterns
{
    public class Observer
    {
        //the subject runs in a thread and changes its state
        //independantly. At each change, it notifie its observers.

        public class Subject
        {
            public delegate void Callback(string s);

            public event Callback Notify;

            private Simulator simulator = new Simulator();
            private const int speed = 200;
            public string SubjectState { get; set; }

            public void Go()
            {
                new Thread(new ThreadStart(Run)).Start();
            }

            private void Run()
            {
                foreach (string s in simulator)
                {
                    Console.WriteLine("Subject: " + s);
                    SubjectState = s;
                    Notify(s);
                    Thread.Sleep(speed); //milliseconds
                }

            }
        }

        interface IObserver
        {
            void Update(string state);
        }

        public class Observerr : IObserver
        {
            private string name;
            private Subject subject;
            private string state;
            private string gap;

            public Observerr(Subject subject, string name, string gap)
            {
                this.subject = subject;
                this.name = name;
                this.gap = gap;
                subject.Notify += Update;
            }

            public void Update(string subjectState)
            {
                state = subjectState;
                Console.WriteLine(gap + name + ": " + state);
            }

        }

        public class Simulator : IEnumerable
        {
            private string[] moves = { "5", "3", "1", "6", "7" };

            public IEnumerator GetEnumerator()
            {
                foreach (string element in moves)
                {
                    yield return element;
                }
            }

        }

    }




}
