namespace QLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbText = new Label();
            lbID = new Label();
            txtID = new TextBox();
            lbHovaTen = new Label();
            txtHovaten = new TextBox();
            lbNgaySinh = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbGioiTinh = new Label();
            txtGioiTinh = new TextBox();
            lbLop = new Label();
            txtLop = new TextBox();
            lbDTB = new Label();
            txtDTB = new TextBox();
            btNhap = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            dataGridView1 = new DataGridView();
            lbDiaChi = new Label();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Location = new Point(69, 19);
            lbText.Name = "lbText";
            lbText.Size = new Size(95, 15);
            lbText.TabIndex = 0;
            lbText.Text = "Nhập Thông Tin ";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(18, 59);
            lbID.Name = "lbID";
            lbID.Size = new Size(101, 15);
            lbID.TabIndex = 1;
            lbID.Text = "Mã Số Sinh Viên : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(153, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // lbHovaTen
            // 
            lbHovaTen.AutoSize = true;
            lbHovaTen.Location = new Point(18, 85);
            lbHovaTen.Name = "lbHovaTen";
            lbHovaTen.Size = new Size(68, 15);
            lbHovaTen.TabIndex = 3;
            lbHovaTen.Text = "Họ và Tên : ";
            // 
            // txtHovaten
            // 
            txtHovaten.Location = new Point(153, 85);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(148, 23);
            txtHovaten.TabIndex = 4;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Location = new Point(18, 119);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(70, 15);
            lbNgaySinh.TabIndex = 5;
            lbNgaySinh.Text = "Ngày Sinh : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Location = new Point(18, 181);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(63, 15);
            lbGioiTinh.TabIndex = 9;
            lbGioiTinh.Text = "Giới Tính : ";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(143, 184);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(100, 23);
            txtGioiTinh.TabIndex = 10;
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new Point(26, 239);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(30, 15);
            lbLop.TabIndex = 11;
            lbLop.Text = "Lớp ";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(143, 242);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(100, 23);
            txtLop.TabIndex = 12;
            // 
            // lbDTB
            // 
            lbDTB.AutoSize = true;
            lbDTB.Location = new Point(18, 279);
            lbDTB.Name = "lbDTB";
            lbDTB.Size = new Size(97, 15);
            lbDTB.TabIndex = 13;
            lbDTB.Text = "Điểm trung Bình ";
            // 
            // txtDTB
            // 
            txtDTB.Location = new Point(143, 271);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(100, 23);
            txtDTB.TabIndex = 14;
            // 
            // btNhap
            // 
            btNhap.Location = new Point(26, 347);
            btNhap.Name = "btNhap";
            btNhap.Size = new Size(75, 23);
            btNhap.TabIndex = 15;
            btNhap.Text = "Save";
            btNhap.UseVisualStyleBackColor = true;
            btNhap.Click += btNhap_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(153, 347);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(75, 23);
            btUpdate.TabIndex = 16;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(263, 347);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 17;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(358, 426);
            dataGridView1.TabIndex = 18;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(18, 210);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(48, 15);
            lbDiaChi.TabIndex = 21;
            lbDiaChi.Text = "Địa Chỉ ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(143, 213);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(100, 23);
            txtDiaChi.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDiaChi);
            Controls.Add(lbDiaChi);
            Controls.Add(dataGridView1);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btNhap);
            Controls.Add(txtDTB);
            Controls.Add(lbDTB);
            Controls.Add(txtLop);
            Controls.Add(lbLop);
            Controls.Add(txtGioiTinh);
            Controls.Add(lbGioiTinh);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbNgaySinh);
            Controls.Add(txtHovaten);
            Controls.Add(lbHovaTen);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Controls.Add(lbText);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbText;
        private Label lbID;
        private TextBox txtID;
        private Label lbHovaTen;
        private TextBox txtHovaten;
        private Label lbNgaySinh;
        private DateTimePicker dateTimePicker1;
        private Label lbGioiTinh;
        private TextBox txtGioiTinh;
        private Label lbLop;
        private TextBox txtLop;
        private Label lbDTB;
        private TextBox txtDTB;
        private Button btNhap;
        private Button btUpdate;
        private Button btDelete;
        private DataGridView dataGridView1;
        private Label lbDiaChi;
        private TextBox txtDiaChi;
    }
}
