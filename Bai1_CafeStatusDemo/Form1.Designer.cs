namespace CafeStatusDemo;

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
        menuStrip1 = new MenuStrip();
        mnuHeThong = new ToolStripMenuItem();
        mnuDoiMauNen = new ToolStripMenuItem();
        mnuThoat = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblGioHienTai = new ToolStripStatusLabel();
        lblTenQuan = new ToolStripStatusLabel();
        lblTrangThai = new ToolStripStatusLabel();
        timer1 = new System.Windows.Forms.Timer(components);
        colorDialog1 = new ColorDialog();
        lblTieuDe = new Label();
        lblMoTa = new Label();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(684, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuHeThong
        // 
        mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDoiMauNen, mnuThoat });
        mnuHeThong.Name = "mnuHeThong";
        mnuHeThong.Size = new Size(69, 20);
        mnuHeThong.Text = "&Hệ thống";
        // 
        // mnuDoiMauNen
        // 
        mnuDoiMauNen.Name = "mnuDoiMauNen";
        mnuDoiMauNen.Size = new Size(144, 22);
        mnuDoiMauNen.Text = "Đổi &màu nền";
        mnuDoiMauNen.Click += mnuDoiMauNen_Click;
        // 
        // mnuThoat
        // 
        mnuThoat.Name = "mnuThoat";
        mnuThoat.Size = new Size(144, 22);
        mnuThoat.Text = "&Thoát";
        mnuThoat.Click += mnuThoat_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
        statusStrip1.Location = new Point(0, 389);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(684, 22);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblGioHienTai
        // 
        lblGioHienTai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblGioHienTai.Name = "lblGioHienTai";
        lblGioHienTai.Size = new Size(51, 17);
        lblGioHienTai.Text = "00:00:00";
        // 
        // lblTenQuan
        // 
        lblTenQuan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTenQuan.ForeColor = Color.DarkGoldenrod;
        lblTenQuan.Name = "lblTenQuan";
        lblTenQuan.Size = new Size(531, 17);
        lblTenQuan.Spring = true;
        lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
        // 
        // lblTrangThai
        // 
        lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTrangThai.ForeColor = Color.Green;
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(87, 17);
        lblTrangThai.Text = "Đang mở cửa";
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTieuDe.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = Color.Chocolate;
        lblTieuDe.Location = new Point(12, 110);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(660, 45);
        lblTieuDe.TabIndex = 2;
        lblTieuDe.Text = "CHÀO MỪNG ĐẾN VỚI CAFE ÁNH DƯƠNG";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblMoTa
        // 
        lblMoTa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblMoTa.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblMoTa.ForeColor = Color.DimGray;
        lblMoTa.Location = new Point(12, 165);
        lblMoTa.Name = "lblMoTa";
        lblMoTa.Size = new Size(660, 30);
        lblMoTa.TabIndex = 3;
        lblMoTa.Text = "Giờ mở cửa phục vụ: 06:00 - 22:00 hằng ngày";
        lblMoTa.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(684, 411);
        Controls.Add(lblMoTa);
        Controls.Add(lblTieuDe);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bảng trạng thái quán cà phê - Cafe Ánh Dương";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem mnuHeThong;
    private ToolStripMenuItem mnuDoiMauNen;
    private ToolStripMenuItem mnuThoat;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblGioHienTai;
    private ToolStripStatusLabel lblTenQuan;
    private ToolStripStatusLabel lblTrangThai;
    private System.Windows.Forms.Timer timer1;
    private ColorDialog colorDialog1;
    private Label lblTieuDe;
    private Label lblMoTa;
}
