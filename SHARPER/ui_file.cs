using System.Windows.Forms;
using System.Drawing;

public class sharpes_ui
{
    void Window(string name_window, int screen_width, int screen_height)
    {
        Form window = new Form();
        window.height = screen_height;
        window.width = screen_width;
        window.Text = name_window;
        window.Show();
    }

    void Button(string name_button, int position_x, int position_y)
    {
        Button button = new Button();
        button.Location = new Point(position_x, position_y);
        button.Text = name_button;
    }

    void Label(string name_label, int position_x, int position_y)
    {
        Label label = new Label();
        label.Locatin = new Point(position_x, position_y);
        label.Text = name_label;
    }
}