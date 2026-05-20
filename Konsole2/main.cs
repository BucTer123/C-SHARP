using System;

public class Main {
	public static void main(String[] args) {
		Console.WriteLine("Welcome!\n");
		Console.WriteLine("> ");
		string c = Console.ReadLine();
		
		if (c == "help();") {
			Console.WriteLine("1 => help();\n");
			Console.WriteLine("2 => exit();\n");
			Console.WriteLine("3 => startgui(true);\n");
		}
		else if (c == "exit();") {
			exit(0);
		}
		else if (c == "startgui(true);") {
			classui.functionui();
		}
	}
}
//CODE CREATED BY SHALAWA!