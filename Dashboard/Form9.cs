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
using DGVPrinterHelper;

namespace Dashboard
{
    public partial class Form9 : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-P1DI6HBL\SQLEXPRESS;Initial Catalog=db_test;Integrated Security=True");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Table_Siswa] where NIS = '" + tb_nis.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            tb_nis.Text = "";
            display_data();
            MessageBox.Show("Data Delete Sukses");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table_Siswa] where namasiswa= '" + textBox1.Text + "' ";
            DataTable dt = new DataTable();
            SqlDataAdapter datap = new SqlDataAdapter(cmd);
            datap.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            textBox1.Text = "";
        }

        private void brn_edit_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Table_Siswa] set NIS = '" + this.tb_nis.Text + "', namasiswa = '" + this.tb_nama.Text + "' , kelas = '" + this.tb_kelas.Text + "' , jurusan = '" + this.tb_jurusan.Text + "' , alamatrumah = '" + this.tb_alamat.Text + "', foto =@images where NIS = '" + this.tb_nis.Text + "' ";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            display_data();
            MessageBox.Show("Data Edit Sukses");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Expert";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Akbar Rizqullah Putra Susanto";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
