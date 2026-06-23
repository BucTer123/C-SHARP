using System;
using System.Windows.Forms;
using System.Drawing;

class program {
    private static void button_callback(object sender, EventArgs e) {
        exit(0);
    }

    private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Form win1 = new Form();
        win1.Text = "Window!";

        Label txt1 = new Label();
        txt1.Text = "Welcome!";
        txt1.Location = new Point(222, 145);

        this.Controls.Add(txt1);

        Button btn1 = new Button();
        btn1.Location = new Point(223, 146);
        btn1.Text = "Click";
        btn1.Click += new EventHandler(this.button_callback);

        this.Controls.Add(btn1);

        Application.run();

        win1.Show();
        
    }
}
