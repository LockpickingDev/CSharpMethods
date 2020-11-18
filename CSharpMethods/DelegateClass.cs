using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpMethods
{
    class DelegateClass
    {
        /***  Everything here are examples from C# notes so far ***/

        // Declare a delegate that takes a single string parameter and has no return type.
        public delegate void LogHandler(string message);

        // Test Application which calls both Delegates
        public class TestApplication
        {
            // Static Function which is used in the Delegate
            static void Logger(string s)
            {
                Console.WriteLine(s);
            }

            //static void Main(string[] args)
            static void MainTempName(string[] args)
            {
                FileLogger fl = new FileLogger("process.log");

                DelegateClass myClass = new DelegateClass();

                // Crate an instance of the delegates, pointing to the static Logger() function defined in the TestApplication class and
                // then to member function on the fl instance of a FileLogger.
                DelegateClass.LogHandler myLogger = null;
                myLogger += new DelegateClass.LogHandler(Logger);
                myLogger += new DelegateClass.LogHandler(fl.Logger);

                myClass.Process(myLogger);
                fl.Close();
            }
        }

        // The use of the delegate is just like calling a function directly, though we need to add a check to see if the delegate is null
        // (that is, not pointing to a function) before calling the function.
        public void Process(LogHandler logHandler)
        {
            if (logHandler != null)
            {
                logHandler("Process() begin");
            }

            if (logHandler != null)
            {
                logHandler("Process() end");
            }
        }

        // The FileLogger class merely encapsulates the file I/O
        public class FileLogger
        {
            FileStream fileStream;
            StreamWriter streamWriter;

            // Constructor
            public FileLogger(string filename)
            {
                fileStream = new FileStream(filename, FileMode.Create);
                streamWriter = new StreamWriter(fileStream);
            }

            // Member Function which is used in the Delegate
            public void Logger(string s)
            {
                streamWriter.WriteLine(s);
            }

            public void Close()
            {
                streamWriter.Close();
                fileStream.Close();
            }
        }


    }//class DelegateClass
}//namespace CSharpMethods
