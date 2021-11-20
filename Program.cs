using System;

namespace ListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            ListofMonths months = new ListofMonths();

            Console.Write("Please enter name of month to see the month number: ");
            string name = Console.ReadLine();

            Console.WriteLine($"The number of {name} is {months[name]}");

            foreach (var item in months)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            Console.WriteLine();

            //create new _List with capacity 10
            _List<Int32> _list = new _List<int>(10);

            //add some elements to the _list
            _list.Add(10);
            _list.Add(12);
            _list.Add(7);
            _list.Add(12);
            _list.Add(14);
            _list.Add(16);
            _list.Add(13);
            _list.Add(11);
            _list.Add(12);
            _list.Add(8);

            foreach (var item in _list)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            Console.WriteLine();

            Console.WriteLine($"there are {_list.Count} elements in the _list");
            Console.WriteLine($"index of element {_list[2]} is: {_list.IndexOf(_list[2])}");
            Console.WriteLine($"index of element {_list[3]} is: {_list.IndexOf(_list[3], 2)}");

            //list operation
            _list.Insert(4, 200);
            _list.Remove(12);

            foreach (var item in _list)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
