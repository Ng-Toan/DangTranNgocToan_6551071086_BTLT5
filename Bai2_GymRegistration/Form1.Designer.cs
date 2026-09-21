namespace GymRegistration;

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
        components = new System.ComponentModel.Container();
        toolTip1 = new ToolTip(components);
        lblTieuDe = new Label();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblSDT = new Label();
        txtSDT = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblNgaySinh = new Label();
        dtpNgaySinh = new DateTimePicker();
        lblGoiTap = new Label();
        cboGoiTap = new ComboBox();
        lblSoBuoiTuan = new Label();
        numSoBuoiTuan = new NumericUpDown();
        btnDangKy = new Button();
        btnLamMoi = new Button();
        panelHeader = new Panel();
        ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.SteelBlue;
        panelHeader.Controls.Add(lblTieuDe);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(540, 60);
        panelHeader.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = DockStyle.Fill;
        lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = Color.White;
        lblTieuDe.Location = new Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(540, 60);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "ĐĂNG KÝ HỘI VIÊN FITLIFE GYM";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblHoTen.Location = new Point(45, 90);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(74, 17);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ và tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Font = new Font("Segoe UI", 10F);
        txtHoTen.Location = new Point(165, 87);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ và tên hội viên...";
        txtHoTen.Size = new Size(320, 25);
        txtHoTen.TabIndex = 2;
        toolTip1.SetToolTip(txtHoTen, "Nhập đầy đủ họ và tên của hội viên");
        // 
        // lblSDT
        // 
        lblSDT.AutoSize = true;
        lblSDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSDT.Location = new Point(45, 135);
        lblSDT.Name = "lblSDT";
        lblSDT.Size = new Size(94, 17);
        lblSDT.TabIndex = 3;
        lblSDT.Text = "Số điện thoại:";
        // 
        // txtSDT
        // 
        txtSDT.Font = new Font("Segoe UI", 10F);
        txtSDT.Location = new Point(165, 132);
        txtSDT.Name = "txtSDT";
        txtSDT.PlaceholderText = "09xxxxxxxx";
        txtSDT.Size = new Size(320, 25);
        txtSDT.TabIndex = 4;
        toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEmail.Location = new Point(45, 180);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(46, 17);
        lblEmail.TabIndex = 5;
        lblEmail.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.Location = new Point(165, 177);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "example@gmail.com";
        txtEmail.Size = new Size(320, 25);
        txtEmail.TabIndex = 6;
        toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
        // 
        // lblNgaySinh
        // 
        lblNgaySinh.AutoSize = true;
        lblNgaySinh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNgaySinh.Location = new Point(45, 225);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new Size(74, 17);
        lblNgaySinh.TabIndex = 7;
        lblNgaySinh.Text = "Ngày sinh:";
        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        dtpNgaySinh.Font = new Font("Segoe UI", 10F);
        dtpNgaySinh.Format = DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new Point(165, 222);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new Size(320, 25);
        dtpNgaySinh.TabIndex = 8;
        toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");
        // 
        // lblGoiTap
        // 
        lblGoiTap.AutoSize = true;
        lblGoiTap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblGoiTap.Location = new Point(45, 270);
        lblGoiTap.Name = "lblGoiTap";
        lblGoiTap.Size = new Size(57, 17);
        lblGoiTap.TabIndex = 9;
        lblGoiTap.Text = "Gói tập:";
        // 
        // cboGoiTap
        // 
        cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGoiTap.Font = new Font("Segoe UI", 10F);
        cboGoiTap.FormattingEnabled = true;
        cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
        cboGoiTap.Location = new Point(165, 267);
        cboGoiTap.Name = "cboGoiTap";
        cboGoiTap.Size = new Size(320, 25);
        cboGoiTap.TabIndex = 10;
        toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
        // 
        // lblSoBuoiTuan
        // 
        lblSoBuoiTuan.AutoSize = true;
        lblSoBuoiTuan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSoBuoiTuan.Location = new Point(45, 315);
        lblSoBuoiTuan.Name = "lblSoBuoiTuan";
        lblSoBuoiTuan.Size = new Size(95, 17);
        lblSoBuoiTuan.TabIndex = 11;
        lblSoBuoiTuan.Text = "Số buổi/tuần:";
        // 
        // numSoBuoiTuan
        // 
        numSoBuoiTuan.Font = new Font("Segoe UI", 10F);
        numSoBuoiTuan.Location = new Point(165, 313);
        numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
        numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSoBuoiTuan.Name = "numSoBuoiTuan";
        numSoBuoiTuan.Size = new Size(120, 25);
        numSoBuoiTuan.TabIndex = 12;
        numSoBuoiTuan.Value = new decimal(new int[] { 3, 0, 0, 0 });
        toolTip1.SetToolTip(numSoBuoiTuan, "Số buổi tập dự kiến trong tuần (từ 1 đến 7 buổi)");
        // 
        // btnDangKy
        // 
        btnDangKy.BackColor = Color.SeaGreen;
        btnDangKy.Cursor = Cursors.Hand;
        btnDangKy.FlatStyle = FlatStyle.Flat;
        btnDangKy.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnDangKy.ForeColor = Color.White;
        btnDangKy.Location = new Point(165, 365);
        btnDangKy.Name = "btnDangKy";
        btnDangKy.Size = new Size(160, 38);
        btnDangKy.TabIndex = 13;
        btnDangKy.Text = "ĐĂNG KÝ";
        btnDangKy.UseVisualStyleBackColor = false;
        btnDangKy.Click += btnDangKy_Click;
        toolTip1.SetToolTip(btnDangKy, "Bấm để hoàn tất việc đăng ký hội viên");
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = Color.Silver;
        btnLamMoi.Cursor = Cursors.Hand;
        btnLamMoi.FlatStyle = FlatStyle.Flat;
        btnLamMoi.Font = new Font("Segoe UI", 10F);
        btnLamMoi.ForeColor = Color.Black;
        btnLamMoi.Location = new Point(340, 365);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(145, 38);
        btnLamMoi.TabIndex = 14;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(540, 435);
        Controls.Add(btnLamMoi);
        Controls.Add(btnDangKy);
        Controls.Add(numSoBuoiTuan);
        Controls.Add(lblSoBuoiTuan);
        Controls.Add(cboGoiTap);
        Controls.Add(lblGoiTap);
        Controls.Add(dtpNgaySinh);
        Controls.Add(lblNgaySinh);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Controls.Add(txtSDT);
        Controls.Add(lblSDT);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        Controls.Add(panelHeader);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form đăng ký hội viên phòng Gym - FitLife";
        ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
        panelHeader.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolTip toolTip1;
    private Panel panelHeader;
    private Label lblTieuDe;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblSDT;
    private TextBox txtSDT;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblNgaySinh;
    private DateTimePicker dtpNgaySinh;
    private Label lblGoiTap;
    private ComboBox cboGoiTap;
    private Label lblSoBuoiTuan;
    private NumericUpDown numSoBuoiTuan;
    private Button btnDangKy;
    private Button btnLamMoi;
}
