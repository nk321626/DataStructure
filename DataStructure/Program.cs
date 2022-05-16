// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problem Program!");

            //Console.WriteLine("Search Operation !");
            Console.WriteLine("Search Operation !");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            int position = list.Search(40);
            list.DeleteNodeAtParticularPosition(position);
            Console.WriteLine("\nAfter deleting 40 then size and final sequence is: ");

            //list.AddReverse(70);
            //list.AddReverse(30);
            //list.AddReverse(56);
            //list.Appending(56);
            //list.Appending(30);
            //list.Appending(70);
            //Console.WriteLine("Display Nodes Are:");
            list.Display();
            //list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}
