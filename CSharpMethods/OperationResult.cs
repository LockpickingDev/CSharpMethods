using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    public class OperationResult
    {
        public bool success { get; set; }
        public List<string> MessageList { get; private set; }

        public OperationResult()
        {
            success = true;
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
    }
}
