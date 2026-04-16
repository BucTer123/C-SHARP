using System;
using System.IO;

class Program {
    void Main() {
        Console.WriteLine("Welcome!\n");

        Console.WriteLine("> ");
        string c = Console.ReadLine();

        if (c == "help") {
            mainclass.list();
        }
        else if (c == "exit") {
            return 0;
        }
        else if (c == "calc") {
            classmath.math();
        }
        else if (c == "time") {
            classtime.time();
        }
    }
}