using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

public class firstbuttonfileclass {
    private static void submit_callback() {
        string text = input.text;
        Directory.CreateDirectory(text);
        MessageBox.Show("Created " + text);
    }

    private static void buttonfilefunction1() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Form w2 = new Form();
        w2.Text = "Create Directory Window";
        w2.width = 800;
        w2.height = 600;

        TextBox input = new TextBox();
        input.Text = "Name :";
        input.Location = new Point(400, 10);

        this.ControlsAdd(input);

        Button button = new Button();
        button.Text = "Submit";
        button.Location = new Point(400, 20);
        button.Click += new EventHandler(this.submit_callback);

        this.ControlsAdd(button);

        w2.Show();
    }
}