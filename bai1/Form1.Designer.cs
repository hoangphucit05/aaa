namespace bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMaTheLoai;
        private Label lblTenTheLoai;
        private Label lblMoTa;
        private Label lblNgayTao;
        private Label lblNgayTaoValue;
        private TextBox txtMaTheLoai;
        private TextBox txtTenTheLoai;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private DataGridView dgvTheLoaiSach;
        private DataGridViewTextBoxColumn colMaTL;
        private DataGridViewTextBoxColumn colTenTheLoai;
        private DataGridViewTextBoxColumn colMoTa;
        private DataGridViewTextBoxColumn colSoLuongSach;
        private DataGridViewTextBoxColumn colNgayTao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMaTheLoai = new Label();
            lblTenTheLoai = new Label();
            lblMoTa = new Label();
            lblNgayTao = new Label();
            lblNgayTaoValue = new Label();
            txtMaTheLoai = new TextBox();
            txtTenTheLoai = new TextBox();
            txtMoTa = new TextBox();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            dgvTheLoaiSach = new DataGridView();
            colMaTL = new DataGridViewTextBoxColumn();
            colTenTheLoai = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            colSoLuongSach = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).BeginInit();
            SuspendLayout();
            // 
            // lblMaTheLoai
            // 
            lblMaTheLoai.AutoSize = true;
            lblMaTheLoai.Location = new Point(24, 28);
            lblMaTheLoai.Name = "lblMaTheLoai";
            lblMaTheLoai.Size = new Size(68, 15);
            lblMaTheLoai.TabIndex = 0;
            lblMaTheLoai.Text = "Mã thể loại";
            // 
            // lblTenTheLoai
            // 
            lblTenTheLoai.AutoSize = true;
            lblTenTheLoai.Location = new Point(24, 65);
            lblTenTheLoai.Name = "lblTenTheLoai";
            lblTenTheLoai.Size = new Size(69, 15);
            lblTenTheLoai.TabIndex = 1;
            lblTenTheLoai.Text = "Tên thể loại";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(24, 103);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(39, 15);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả";
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(24, 178);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(55, 15);
            lblNgayTao.TabIndex = 3;
            lblNgayTao.Text = "Ngày tạo";
            // 
            // lblNgayTaoValue
            // 
            lblNgayTaoValue.AutoSize = true;
            lblNgayTaoValue.Location = new Point(112, 178);
            lblNgayTaoValue.Name = "lblNgayTaoValue";
            lblNgayTaoValue.Size = new Size(16, 15);
            lblNgayTaoValue.TabIndex = 4;
            lblNgayTaoValue.Text = "—";
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(112, 24);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.ReadOnly = true;
            txtMaTheLoai.Size = new Size(245, 23);
            txtMaTheLoai.TabIndex = 5;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(112, 61);
            txtTenTheLoai.MaxLength = 100;
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(245, 23);
            txtTenTheLoai.TabIndex = 6;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(112, 98);
            txtMoTa.MaxLength = 255;
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(245, 62);
            txtMoTa.TabIndex = 7;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(24, 218);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
            txtTimKiem.Size = new Size(333, 23);
            txtTimKiem.TabIndex = 8;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(400, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 32);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(501, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 32);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(602, 24);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 32);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(703, 24);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(92, 32);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(369, 217);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(92, 25);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvTheLoaiSach
            // 
            dgvTheLoaiSach.AllowUserToAddRows = false;
            dgvTheLoaiSach.AllowUserToDeleteRows = false;
            dgvTheLoaiSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTheLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoaiSach.BackgroundColor = SystemColors.ControlDark;
            dgvTheLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoaiSach.Columns.AddRange(new DataGridViewColumn[] { colMaTL, colTenTheLoai, colMoTa, colSoLuongSach, colNgayTao });
            dgvTheLoaiSach.Location = new Point(24, 260);
            dgvTheLoaiSach.MultiSelect = false;
            dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            dgvTheLoaiSach.ReadOnly = true;
            dgvTheLoaiSach.RowHeadersWidth = 30;
            dgvTheLoaiSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoaiSach.Size = new Size(771, 280);
            dgvTheLoaiSach.TabIndex = 14;
            dgvTheLoaiSach.SelectionChanged += dgvTheLoaiSach_SelectionChanged;
            // 
            // colMaTL
            // 
            colMaTL.FillWeight = 55F;
            colMaTL.HeaderText = "Mã TL";
            colMaTL.Name = "colMaTL";
            colMaTL.ReadOnly = true;
            // 
            // colTenTheLoai
            // 
            colTenTheLoai.FillWeight = 105F;
            colTenTheLoai.HeaderText = "Tên thể loại";
            colTenTheLoai.Name = "colTenTheLoai";
            colTenTheLoai.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.FillWeight = 155F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // colSoLuongSach
            // 
            colSoLuongSach.FillWeight = 80F;
            colSoLuongSach.HeaderText = "Số lượng sách";
            colSoLuongSach.Name = "colSoLuongSach";
            colSoLuongSach.ReadOnly = true;
            // 
            // colNgayTao
            // 
            colNgayTao.FillWeight = 110F;
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.Name = "colNgayTao";
            colNgayTao.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 565);
            Controls.Add(dgvTheLoaiSach);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenTheLoai);
            Controls.Add(txtMaTheLoai);
            Controls.Add(lblNgayTaoValue);
            Controls.Add(lblNgayTao);
            Controls.Add(lblMoTa);
            Controls.Add(lblTenTheLoai);
            Controls.Add(lblMaTheLoai);
            MinimumSize = new Size(760, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Thể Loại Sách - Tri Thức Books";
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
