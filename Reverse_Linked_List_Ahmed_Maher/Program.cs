using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List_Ahmed_Maher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MaherList = new LinkedList<string>();

            LinkedListNode<string> MaherNode = MaherList.AddFirst("spiderman3");
            MaherList.AddFirst("TF");
            MaherList.AddFirst("Optimus prime");
            MaherList.AddFirst("Halo");
            MaherList.AddFirst("Naruto");
            MaherList.AddFirst("Madara Uchiha");
            MaherList.AddFirst("Mortal Kombat");
            MaherList.AddFirst("Scorpion");
            MaherList.AddBefore(MaherNode, "Kill Zone");
            MaherList.AddLast("Metal Gear Solid");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The linked List Before Reversig:  ");
            Console.WriteLine("----------------------------------");
            foreach (var item in MaherList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The linked List After Reversing: ");
            Console.WriteLine("----------------------------------");
            foreach (var item in MaherList.Reverse())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
