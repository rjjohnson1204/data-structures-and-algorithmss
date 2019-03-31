using System;
using System.Collections.Generic;
using System.Text;


namespace Tree.Classes
{
    public class Trees
    {
        public Node Root { get; set; }
        public Node Current { get; set; }

        public Tree()
        {
            Root = null;
            Current = Root;
        }

        public Tree(Node node)
        {
            Root = node;
            Current = Root;
        }
    }
}
