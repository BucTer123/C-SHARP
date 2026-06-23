using System;
using System.Windows.Forms;
using System.Drawing;

public class Program {
    private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Form win1 = new Form();
        win1.Text = "Window!";

        TextBox input = new TextBox();
        input.Text = "> ";
        input.width = 200;
        
        this.Controls.Add(input);

        Application.run();

        win1.Show();
    }
}