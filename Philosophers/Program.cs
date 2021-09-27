using System;
using System.Collections.Generic;
using System.Threading;

namespace Philosophers
{
    class Program
    {
        public static List<Stick> sticks;
        public static List<Philosoher> philosohers;

        static void Main(string[] args)
        {
            
            sticks = new List<Stick>();
            for (int i = 0; i < 5; i++)
            {
                sticks.Add(new Stick { Id = i });

            }

            philosohers = new List<Philosoher>();
            for (int i = 0; i < 5; i++)
            {
                philosohers.Add(new Philosoher { Id = i });
            }


            for (int i = 0; i < philosohers.Count; i++)
            {
                Thread t = new Thread(new ThreadStart(StartPhilosophers));
                t.Start();
            }
            
        }

        public static void StartPhilosophers()
        {
            


        }









        public static void Eat()
        {

        }

        public static void TakeSticks()
        {

        }

        public static void Sleep()
        {

        }
    }

    public class Stick
    {
        public int Id { get; set; }

    }

    public class Philosoher
    {
        public int Id { get; set; }

        private bool _isSleeping = true;

        public bool IsSleeping
        {
            get { return _isSleeping; }
            set { _isSleeping = value; }
        }



    }
}
