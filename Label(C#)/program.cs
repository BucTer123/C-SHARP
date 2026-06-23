using System;
using System.Windows.Forms;
using System.Drawing;

class Program {
    private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Form win1 = new Form();
        win1.Text = "Window!";

        Label txt1 = new Label();
        txt1.Text = "Welcome!";
        txt1.ImageIndex = 1;
        txt1.Location = new Point(400, 300);

        this.Controls.Add(txt1);
        
        Application.run();

        win1.Show();
    }
}
