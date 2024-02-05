using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getter & Setters - Practice 
            Motorcycle motor1 = new Motorcycle(130);
            Console.WriteLine(motor1.Motor);


            Console.ReadKey();
        }
    }

    class Motorcycle
    {
        private int motor;

        public Motorcycle(int motor)
        {
            Motor = motor;
        }

        public int Motor
        {
            get { return motor; }
            set
            {
                if (value > 120)
                {
                    motor = 120;
                }
                else
                {
                    motor = value;
                }
            }

        }
    }

}