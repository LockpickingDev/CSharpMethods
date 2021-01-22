using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    public class Node
    {
        public string value { get; set; }
        public Node next;

        public Node()
        {
            next = null;
        }

        public Node(string val)
        {
            next = null;
            value = val;
        }

        //public string value()
        //{
        //    return value;
        //}


    }//END class Node
}
