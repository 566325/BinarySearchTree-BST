namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);

            Console.Write("preOrder Traversal  :  Rooot-Left -RightLeft ");
            tree.Display(tree.ReturnRoot());
            Console.Write("Post Order Traversal  :  Left-Right-Root ");
            tree.Display(tree.ReturnRoot());
            Console.Write("InOrder Traversal  : Left-Rooot-right ");
            tree.Display(tree.ReturnRoot());


        }
    }
}