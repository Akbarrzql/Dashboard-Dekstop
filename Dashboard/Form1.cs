using System.Data.SqlClient;
using System.Data;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        readonly string Username = "akbarrzql";
        readonly string Password = "Akbar228";
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P1DI6HBL\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("tutup Dashboard ini ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == Username && txtpassword.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            else if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
            

            /*
            String username, password;

            username = txtusername.Text;
            password = txtpassword.Text;

            try
            {

                String querry = "SELECT * FROM Table WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtusername.Text;
                    password = txtpassword.Text;

                    //
                    Form1 form3 = new Form1();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();

                    //
                    txtusername.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            */

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}