using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IN255M2Assessment
{
    internal class Program
    {
        struct Car
        {
            public string Make;
            public string Model;
            public int ModelYear;

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                ModelYear = year;
            }
        }

        static void Main()
        {
            Section1();
            Section2();
            Section3();
            Section4();
            Section5();
        }

        /* 
         * 
         * IN255M2 Assessment Part 3 Section 1
         * 
         */

        public static void Section1()
        {
            Car[] approvedCars = new Car[]
            {
                new Car("Ford", "Mustang", 2010),
                new Car("Chevrolet", "Silverado", 2008),
                new Car("Dodge", "Charger", 2012)
            };

            Console.WriteLine("Section 1: Array of Structures" + "\n");

            foreach (Car car in approvedCars)
            {
                Console.WriteLine(car.Make + ", " + car.Model + ", " + car.ModelYear + "\n");
            }
        }

        /*
         * 
         * IN255M2 Assessment Part 3 Section 2
         * 
         */

        public static void Section2()
        {
            Dictionary<string, int> inventoryCount = new Dictionary<string, int>
            {
                {"Mustang", 9 },
                {"Silverado", 13 },
                {"Charger", 4 }
            };

            Console.WriteLine("Section 2: Inventory Count\n");

            foreach (var item in inventoryCount)
            {
                Console.WriteLine("There are: " + item.Value + " " + item.Key + "\n");
            }
        }

        /* 
         * 
         * IN255M2 Assessment Part 3 Section 3
         * 
         */

        public static void Section3()
        {
            ArrayList DaysOfWeek = new ArrayList()
            {
                "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            Console.WriteLine("Section 3: Days of the Week \n");

            foreach (string day in DaysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();
            for (int i = DaysOfWeek.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(DaysOfWeek[i] + "\n");
            }

            ArrayList WorkDays = new ArrayList(DaysOfWeek);
            WorkDays.Remove("Saturday");
            WorkDays.Remove("Sunday");

            Console.WriteLine("Work Days: \n");
            foreach (string day in WorkDays)
            {
                Console.WriteLine(day + "\n");
            }
        }

        /* 
         * 
         * IN255M2 Assessment Part 3 Section 4
         * 
         */
        public static void Section4()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(24);
            stack.Push(31);
            stack.Push(45);
            stack.Push(19);
            stack.Push(76);

            Console.WriteLine("Section 4: Stack \n");
            Console.WriteLine("There are " + stack.Count + " items in teh stack.\n");

            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("There are " + stack.Count + " items in the stack." + "\n");

            Console.WriteLine("The next item is: " + stack.Peek() + "\n");
        }

        /* 
         * 
         * IN255M2 Assessment Part 3 Section 5
         * 
         */

        public static void Section5()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(24);
            queue.Enqueue(31);
            queue.Enqueue(45);
            queue.Enqueue(19);
            queue.Enqueue(76);

            Console.WriteLine("Section 5: Queue \n");
            Console.WriteLine("There are " + queue.Count + " items in teh queue. \n");

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("There are " + queue.Count + " items in teh queue. \n");

            Console.WriteLine("The next item is: " + queue.Peek() + "\n");
        }
    }
}
