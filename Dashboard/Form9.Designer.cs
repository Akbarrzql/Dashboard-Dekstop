namespace Dashboard
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nis = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_kelas = new System.Windows.Forms.TextBox();
            this.tb_jurusan = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.brn_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_keluar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Input Data Siswa";
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.Red;
            this.btn_keluar.ForeColor = System.Drawing.Color.White;
            this.btn_keluar.Location = new System.Drawing.Point(967, 57);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(94, 29);
            this.btn_keluar.TabIndex = 1;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Siswa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kelas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jurusan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(98, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat Rumah:";
            // 
            // tb_nis
            // 
            this.tb_nis.Location = new System.Drawing.Point(259, 190);
            this.tb_nis.Name = "tb_nis";
            this.tb_nis.Size = new System.Drawing.Size(289, 27);
            this.tb_nis.TabIndex = 6;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(259, 238);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(289, 27);
            this.tb_nama.TabIndex = 7;
            // 
            // tb_kelas
            // 
            this.tb_kelas.Location = new System.Drawing.Point(259, 285);
            this.tb_kelas.Name = "tb_kelas";
            this.tb_kelas.Size = new System.Drawing.Size(289, 27);
            this.tb_kelas.TabIndex = 8;
            // 
            // tb_jurusan
            // 
            this.tb_jurusan.Location = new System.Drawing.Point(259, 337);
            this.tb_jurusan.Name = "tb_jurusan";
            this.tb_jurusan.Size = new System.Drawing.Size(289, 27);
            this.tb_jurusan.TabIndex = 9;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(259, 388);
            this.tb_alamat.Multiline = true;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(289, 156);
            this.tb_alamat.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Sample_User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(714, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(761, 383);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(94, 29);
            this.btn_browse.TabIndex = 12;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(951, 186);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(951, 238);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(94, 29);
            this.btn_input.TabIndex = 14;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(951, 287);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // brn_edit
            // 
            this.brn_edit.Location = new System.Drawing.Point(951, 337);
            this.brn_edit.Name = "brn_edit";
            this.brn_edit.Size = new System.Drawing.Size(94, 29);
            this.brn_edit.TabIndex = 16;
            this.brn_edit.Text = "Edit";
            this.brn_edit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 565);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(964, 188);
            this.dataGridView1.TabIndex = 17;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(951, 388);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(94, 29);
            this.btn_display.TabIndex = 18;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 775);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.tb_jurusan);
            this.Controls.Add(this.tb_kelas);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_nis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_keluar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_nis;
        private TextBox tb_nama;
        private TextBox tb_kelas;
        private TextBox tb_jurusan;
        private TextBox tb_alamat;
        private PictureBox pictureBox1;
        private Button btn_browse;
        private Button btn_clear;
        private Button btn_input;
        private Button btn_delete;
        private Button brn_edit;
        private DataGridView dataGridView1;
        private Button btn_display;
    }
}