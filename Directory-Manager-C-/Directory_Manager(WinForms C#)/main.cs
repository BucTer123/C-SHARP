using System;
using System.Windows.Forms;
using System.Drawing;

public class App {
    private static void first_button_callback() {
        firstbuttonfileclass.buttonfilefunction1();
    }

    private static void second_button_callback() {
        secondbuttonfileclass.buttonfilefunction2();
    }

    private static void exit_callback() {
        MessageBox.Show("Bye!");
        exit(0);
    }

    private static void start_serv() {
        MessageBox.Show("Starting");
        System.Diagnostics.Process.Start("python3 sv.py");
    }

    private static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        InitializeComponent();

        Form w1 = new Form();
        w1.Text = "MainWindow";
        w1.width = 800;
        w1.height = 600;

        Label t1 = new Label();
        t1.Text = "Welcome!";
        t1.ImageIndex = 1;
        t1.Location = new Point(400, 10);

        this.ControlsAdd(t1);

        Button b1 = new Button();
        b1.Text = "Create Directory";
        b1.Location = new Point(400, 20);
        b1.Click += new EventHandler(this.first_button_callback);

        this.ControlsAdd(b1);

        Button b2 = new Button();
        b2.Text = "Remove Directory";
        b2.Location = new Point(400, 30);
        b2.Click += new EventHandler(this.second_button_callback);
        
        this.ControlsAdd(b2);

        Button b3 = new Button();
        b3.Text = "Exit";
        b3.Location = new Point(400, 40);
        b3.Click += new EventHandler(this.exit_callback);

        this.ControlsAdd(b3);

        Button b4 = new Button();
        b4.Text = "Start Web Server in Python";
        b4.Location = new Point(400, 50);
        b4.Click += new EventHandler(this.start_serv);

        this.ControlsAdd(b4);

        w1.Show();
    }
}
