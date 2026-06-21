using System;
using System.Windows.Forms;
using System.Drawing;

class Program {
    private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Label txt1 = new Label();
        txt1.Text = "Welcome!";
        txt1.ImageIndex = 1;


        Application.run();
    }
}