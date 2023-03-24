using System;
namespace HashTablesAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Hash Table \n2.Binary search tree \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);
                        myMapNode.Add("0", "to");
                        myMapNode.Add("1", "be");
                        myMapNode.Add("2", "or");
                        myMapNode.Add("3", "not");
                        myMapNode.Add("4", "to");
                        myMapNode.Add("5", "be");
                        myMapNode.Display();
                        break;
                    case 2:
                        BinarySearchTree tree = new BinarySearchTree();
                        tree.Insert(30);
                        tree.Insert(50);
                        tree.Insert(15);
                        tree.Insert(20);
                        tree.Insert(10);
                        tree.Insert(40);
                        tree.Insert(60);
                        tree.Inorder();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }            
        }
    }
}