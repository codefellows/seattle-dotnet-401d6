using _401d6LinkedList.Classes;
using System;

namespace _401d6LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NodeExample();
        }

        static void NodeExample()
        {
            //Node node = new Node(8);
            //Console.WriteLine(node.Value);
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            list.Print();

            list.Append(16);
            list.Append(23);
            list.Append(42);

            list.Print();

            list.InsertBefore(23, 53);

            list.Print();

            //Console.WriteLine($"Does 8 Exist?: {list.Includes(8)}");
            //Console.WriteLine($"Does 18 Exist?: {list.Includes(18)}");


        }
    }
}
