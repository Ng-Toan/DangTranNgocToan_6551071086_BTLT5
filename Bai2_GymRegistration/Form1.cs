namespace GymRegistration;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // Cấu hình thuộc tính cho ToolTip trong constructor theo yêu cầu
        toolTip1.AutoPopDelay = 5000;
        toolTip1.InitialDelay = 500;
        toolTip1.ReshowDelay = 100;
        toolTip1.ShowAlways = true;

        // Chọn mặc định gói tập đầu tiên
        if (cboGoiTap.Items.Count > 0)
        {
            cboGoiTap.SelectedIndex = 0;
        }
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();
        string sdt = txtSDT.Text.Trim();

        // Kiểm tra nếu họ tên hoặc số điện thoại để trống
        if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sdt))
        {
            MessageBox.Show(
                "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                "Cảnh báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? "(Không có)" : txtEmail.Text.Trim();
        string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
        string goiTap = cboGoiTap.SelectedItem?.ToString() ?? "Basic";
        decimal soBuoi = numSoBuoiTuan.Value;

        // Hiển thị tổng hợp thông tin đã đăng ký
        string thongTin = $"=== ĐĂNG KÝ HỘI VIÊN THÀNH CÔNG ===\n\n" +
                          $"• Họ và tên: {hoTen}\n" +
                          $"• Số điện thoại: {sdt}\n" +
                          $"• Email: {email}\n" +
                          $"• Ngày sinh: {ngaySinh}\n" +
                          $"• Gói tập: {goiTap}\n" +
                          $"• Số buổi/tuần: {soBuoi} buổi";

        MessageBox.Show(
            thongTin,
            "Thông tin đăng ký hội viên",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtSDT.Clear();
        txtEmail.Clear();
        dtpNgaySinh.Value = DateTime.Now;
        if (cboGoiTap.Items.Count > 0) cboGoiTap.SelectedIndex = 0;
        numSoBuoiTuan.Value = 3;
        txtHoTen.Focus();
    }
}
