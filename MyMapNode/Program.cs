using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyMapNode

{
    internal class Program
    {
        static void Main(string[] args)
        {
             //1.The hash variable is declared as a MyMapNode<string, string> object.
             //2.The hash object is initialized with a size of 5.
             //3.The Add method is used to add the key / value pairs to the hash.
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To ");
            hash.Add("1", "be ");
            hash.Add("2", "or ");
            hash.Add("3", "not ");
            hash.Add("4", "to ");
            hash.Add("5", "be");

            //It prints out the values of the keys 0, 1, 2, 3, 4, and 5.

            Console.Write(hash.GetV("0"));
            Console.Write(hash.GetV("1"));
            Console.Write(hash.GetV("2"));
            Console.Write(hash.GetV("3"));
            Console.Write(hash.GetV("4"));
            Console.Write(hash.GetV("5"));
            Console.ReadLine();
        }
    }
}