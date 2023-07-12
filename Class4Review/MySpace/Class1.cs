using System;

namespace Class4Review.MySpace
{
    public class Class1
    {
        public string[] students { get; set; }
        public Class1()
        {
            students = new string[19];
        }

        public void LockIn() 
        {
            Console.WriteLine("{0} students are Locked In", students.Length);
        }
        public static void LockIn(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Date
    {
        private int _month = 7;  // Backing store

        public int Month
        {
            get => _month;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }
    }
}

//const pizza = { }
//const dylansPizza = new Pizza();

