using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

public class secondbuttonfileclass {
    private static void submit_callback2() {
        string text2 = input2.text;
        Directory.RemoveDirectory(text2);
        MessageBox.Show("Removed! " + text2);
    }

    private static void buttonfilefunction2() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Form w3 = new Form();
        w3.Text = "Remove Directory ";
        w3.width = 800;
        w3.height = 600;

        TextBox input2 = new TextBox();
        input2.Text = "Name :";
        input2.Location = new Point(400, 10);

        this.ControlsAdd(input2);

        Button button2 = new Button();
        button2.Text = "Submit";
        button2.Location = new Point(400, 20);
        button2.Click += new EventHandler(this.submit_callback2)

        this.ControlsAdd(button2);

        w3.Show();
        Application.run();
    }
}