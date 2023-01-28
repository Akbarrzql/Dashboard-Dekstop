using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Dashboard
{
    public partial class Form9 : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-S2EF8PUD\SQLEXPRESS01;Initial Catalog=db_test;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }
        string imglocation = "";
        SqlCommand cmd;

        private void label4_Click(object sender, EventArgs e)
        {
                                                                                               
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_nis.Text = "";
            tb_nama.Text = "";
            tb_kelas.Text = "";
            tb_jurusan.Text = "";
            tb_alamat.Text = "";
            pictureBox1.ImageLocation = null;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Table_Siswa] (nis,namasiswa,kelas,jurusan,alamatrumah,foto) values ( '" + tb_nis.Text + "', '" + tb_nama.Text + "', '" + tb_kelas.Text + "', '" + tb_jurusan.Text + "', '" + tb_alamat.Text + "', @images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("data insert sukses");
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            {
                string message = "Apa kamu yakin ingin logout";
                string title = "Logout dari Akun Anda";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    // Do something  
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*. ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;

            }
        }

        public void display_data()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table_Siswa]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
