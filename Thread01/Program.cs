using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread01
{
    class Program
    {
            public delegate string MyDelegate(string arg1);

        static void Main()
        {
            Thread t = new Thread(WriteY);          // Kick off a new thread
            t.Start();                               // running WriteY()

            for (int i = 0; i < 4; i++)
            {
                Thread l = new Thread(() => Console.Write("Hello World\n"));
                l.Start();
            }

            for (int i = 0; i < 4; i++)
            {
                MyDelegate f = delegate (string arg1)
            {
                return (arg1);
            };
                Console.WriteLine(f("Hello World"));
            }
        }
        static void WriteY()
        {
            for (int i = 0; i < 4; i++) Console.Write("Hello World\n");
            Console.ReadLine();
        }

            //// Simultaneously, do something on the main thread.
            //for (int i = 0; i < 4; i++) Console.Write("Hello World");

            //string a = "Hello World";


            
           
    } 
}
    

