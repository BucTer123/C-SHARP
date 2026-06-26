using System;
using System.Windows.Forms;
using System.Drawing;

class Program {

    String cs = (@"Data Source=/source; Initial Catalog=Something;Integrated Security=True");
    private static void btn1_callback(object sender, EventArgs e) {
        try {
            SqlConnection myConnection = default(SqlConnection);
            myConnection  =new SqlConnection(cs);

            SqlConnection myCommand = default(SqlCommand);

            myCommand = new SqlCommand("SELECT a, b FROM Something WHERE a = @a AND b = @b");

            SqlParameter uA = new SqlParameter("@a", SqlDbType.VarChar);
            SqlParameter uB = new SqlParameter("@b", SqlDbType.VarChar);

            uA.Value = txtA.Text;
            uB.Value = txtB.Text;

            myCommand.Parameters.Add(uA);
            myCommand.Parameters.Add(uB);

            myConnection.Open();

            SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (myReader.Read() == true) {
                Message.Show("+");
            } else {
                Message.Show("-");
            }
            catch (Execeptin ex) {
                Message.Show("-- Error --");
            }
        }
    }
    private static void Main(String[] args) {
        Form win1 = new Form();
        win1.Text = "Window!";
        win1.width = 800;
        win1.height = 600;

        Button btn1 = new Button();
        btn1.Text = "Database";
        btn1.Location = new Point(400, 20);
        btn1.width = 20;
        btn1.height = 10;
        btn1.Click += new EventHandler(this.btn1_callback);

        this.ControlsAdd(btn1);

        win1.Show();
    }
}