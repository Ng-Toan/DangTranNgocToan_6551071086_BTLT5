# BÀI TẬP THỰC HÀNH: LẬP TRÌNH TRỰC QUAN – WINFORMS C# .NET
## Chương 5 — Xử lý Sự kiện & Nhập liệu (Section 2: Bàn phím & Chuột)

Dự án gồm đầy đủ mã nguồn cho 2 bài thực hành theo đúng đặc tả và yêu cầu đề bài:

---

### CÂU 1: Form nhập liệu siêu thị – Kiểm soát phím tắt & lọc ký tự
- **Form**: `FormBanHang.cs`
- **Các thành phần (Controls)**:
  - `txtMaSP`: Mã sản phẩm (chuỗi ký tự).
  - `txtSoLuong`: Số lượng (chỉ cho phép nhập số).
  - `txtDonGia`: Đơn giá (chỉ cho phép nhập số).
  - `btnThem`: Nút "Thêm (F2)".
  - `btnXoaTrang`: Nút "Xóa trắng (F5)".
  - `lstKetQua`: ListBox hiển thị kết quả thêm theo định dạng: `MaSP | SoLuong | DonGia`.
- **Logic xử lý**:
  - `KeyPreview = true`: Cho phép Form bắt các sự kiện phím tắt trước khi chuyển tới control con.
  - Lọc ký tự `KeyPress` trên `txtSoLuong` và `txtDonGia`:
    ```csharp
    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
    {
        e.Handled = true; // Chặn các ký tự không phải số hoặc phím Backspace
    }
    ```
  - Sự kiện `KeyDown` trên Form:
    - Nhấn `F2`: Kích hoạt `btnThem.PerformClick()`, kiểm tra hợp lệ và thêm dòng mới vào `lstKetQua`.
    - Nhấn `F5`: Kích hoạt `btnXoaTrang.PerformClick()`, xóa trắng 3 ô và focus về `txtMaSP`.
    - Nhấn `Escape`: Hiển thị hộp thoại `MessageBox.Show` xác nhận "Bạn có muốn thoát?" với 2 nút Yes/No; chọn Yes sẽ đóng form.

---

### CÂU 2: Bảng vẽ mini – MouseDown, MouseMove, MouseUp & Click phải
- **Form**: `FormBangVe.cs`
- **Các thành phần (Controls)**:
  - `pnlCanvas`: Panel lớn nền trắng dùng làm vùng vẽ tự do (sử dụng kỹ thuật Double-buffered và đệm Bitmap để nét vẽ mượt mà, không bị mất nét).
  - `lblViTri`: Label hiển thị tọa độ chuột `(X, Y)` và trạng thái `"Sẵn sàng"` / `"Đang vẽ..."`.
  - Bảng chọn màu nét vẽ (Đen, Đỏ, Xanh dương, Xanh lá) và nút xóa bảng nhanh.
- **Logic xử lý**:
  - `MouseDown` (Chuột trái): Đánh dấu bắt đầu vẽ (`isDrawing = true`), lưu tọa độ bắt đầu `lastPoint`, cập nhật trạng thái `"Đang vẽ..."`.
  - `MouseMove`:
    - Luôn cập nhật tọa độ chuột `(e.X, e.Y)` lên `lblViTri` dù có đang vẽ hay không.
    - Khi đang giữ chuột trái: Vẽ các đoạn thẳng nối tiếp từ `lastPoint` đến `e.Location` bằng `Graphics.DrawLine`, cập nhật `lastPoint = e.Location`, gọi `pnlCanvas.Invalidate()`.
  - `MouseUp` (Chuột trái): Kết thúc nét vẽ (`isDrawing = false`), cập nhật trạng thái `"Sẵn sàng"`.
  - `MouseClick` (Chuột phải `e.Button == MouseButtons.Right`): Xóa trắng bảng vẽ (`Graphics.Clear(Color.White)`) và gọi `Invalidate()`.

---

### HƯỚNG DẪN CHẠY DỰ ÁN
1. Mở terminal tại thư mục dự án và chạy:
   ```bash
   cd BTChuong5_Section2
   dotnet run
   ```
2. Hoặc mở file `BTChuong5_Section2_Legacy.sln` / `BTChuong5_Section2.slnx` bằng **Visual Studio** và nhấn `F5`.
3. Giao diện `FormMain` sẽ hiện lên cho phép bạn chọn mở trực tiếp **Câu 1** hoặc **Câu 2**.
