using System.Globalization;

namespace Class4Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MySpace.Class1 MyClass = new MySpace.Class1();
            //MySpace.Class1.LockIn("I'm Locked In! 👉🏾"); // static method
            //MyClass.LockIn(); // non static method
            Console.Write(MyClass.students.Length);
            Console.Write("\n");
            MyClass.students[0] = "Jay";
            Console.Write("Student #1 is " + MyClass.students[0]);

            //MySpace.Date todaysDate = new MySpace.Date();
            //Console.WriteLine(todaysDate.Month);
            //todaysDate.Month = 8;
            //Console.WriteLine(todaysDate.Month);
        }
    }
}