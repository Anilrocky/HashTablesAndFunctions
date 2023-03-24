using System;
namespace HashTablesAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);
            myMapNode.Add("0", "to");
            myMapNode.Add("1", "be");
            myMapNode.Add("2", "or");
            myMapNode.Add("3", "not");
            myMapNode.Add("4", "to");
            myMapNode.Add("5", "be");
            string hash2 = myMapNode.Get("2");
            Console.WriteLine("2nd hash value: " + hash2);
            string hash5 = myMapNode.Get("5");
            Console.WriteLine("5th hash value: " + hash5);
        }
    }
}