using System;

class classmath {
    void math() {
        Console.WriteLine("Write first number :");
        float a = Console.ReadLine();

        Console.WriteLine("Write second number :");
        float b = Console.ReadLine();

        Console.WriteLine("> ");
        string calc = Console.ReadLine();

        if (calc == "+") {
            float plus = a + b;
            Console.WriteLine(plus);
        }
        else if (calc == "-") {
            float minus = a - b;
            Console.WriteLine(minus);
        }
        else if (calc == "*") {
            float multi = a * b;
            Console.WriteLine(multi);
        }
        else if (calc == "/") {
            if (b == 0) {
                Console.WriteLine("ERROR!: Divide by zero!\n");
                return 0;
            } else {
                float divide = a / b;
                Console.WriteLine(divide);
            }
        }
    }
}