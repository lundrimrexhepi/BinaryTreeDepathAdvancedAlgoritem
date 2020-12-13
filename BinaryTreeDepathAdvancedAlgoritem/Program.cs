using System;
using static BinaryTreeDepathAdvancedAlgoritem.BinaryTree;

namespace BinaryTreeDepathAdvancedAlgoritem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ju lutem shenojeni me , anterat e vargut");
            string vlerat = Console.ReadLine();
            Node rrenja = null;
            foreach (var item in vlerat.Split(','))
            {
                rrenja = Tree.Mbush(rrenja, int.Parse(item));
            }

            Console.WriteLine("Thellesia eshte : " +  Tree.Llogaritethelsine(rrenja));
        }
    }
}
