namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvTheLoaiSach_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvTheLoaiSach.CurrentRow is not { IsNewRow: false } row
                || row.Cells["colMaTL"].Value is null)
            {
                return;
            }

            txtMaTheLoai.Text = Convert.ToString(row.Cells["colMaTL"].Value) ?? string.Empty;
            txtTenTheLoai.Text = Convert.ToString(row.Cells["colTenTheLoai"].Value) ?? string.Empty;
            txtMoTa.Text = Convert.ToString(row.Cells["colMoTa"].Value) ?? string.Empty;
            lblNgayTaoValue.Text = Convert.ToString(row.Cells["colNgayTao"].Value) ?? "—";
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            var searchText = txtTimKiem.Text.Trim();

            foreach (DataGridViewRow row in dgvTheLoaiSach.Rows)
            {
                var name = Convert.ToString(row.Cells["colTenTheLoai"].Value) ?? string.Empty;
                row.Visible = name.Contains(searchText, StringComparison.CurrentCultureIgnoreCase);
            }
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();
            lblNgayTaoValue.Text = "—";
            dgvTheLoaiSach.ClearSelection();
            txtTenTheLoai.Focus();
        }
    }
}
