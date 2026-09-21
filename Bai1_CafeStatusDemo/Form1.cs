namespace CafeStatusDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CapNhatThoiGianVaTrangThai();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        CapNhatThoiGianVaTrangThai();
    }

    private void CapNhatThoiGianVaTrangThai()
    {
        DateTime now = DateTime.Now;
        lblGioHienTai.Text = now.ToString("HH:mm:ss");

        // Giờ mở cửa: từ 6h đến 22h
        if (now.Hour >= 6 && now.Hour < 22)
        {
            lblTrangThai.Text = "Đang mở cửa";
            lblTrangThai.ForeColor = Color.Green;
        }
        else
        {
            lblTrangThai.Text = "Đã đóng cửa";
            lblTrangThai.ForeColor = Color.Red;
        }
    }

    private void mnuDoiMauNen_Click(object sender, EventArgs e)
    {
        colorDialog1.Color = this.BackColor;
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            this.BackColor = colorDialog1.Color;
        }
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát ứng dụng?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
