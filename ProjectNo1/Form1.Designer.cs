namespace GUI
{
    partial class FrmMain
    {
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnBaoCao;


        private void InitializeComponent()
        {
            btnSanPham = new System.Windows.Forms.Button();
            btnKhachHang = new System.Windows.Forms.Button();
            btnNhanVien = new System.Windows.Forms.Button();
            btnBanHang = new System.Windows.Forms.Button();
            btnBaoCao = new System.Windows.Forms.Button();

            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.Size = new System.Drawing.Size(200, 50);
            btnSanPham.Location = new System.Drawing.Point(80, 30);
            btnSanPham.Click +=
                new System.EventHandler(
                this.btnSanPham_Click);

            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.Size = new System.Drawing.Size(200, 50);
            btnKhachHang.Location = new System.Drawing.Point(80, 100);
            btnKhachHang.Click +=
                new System.EventHandler(
                this.btnKhachHang_Click);

            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.Size = new System.Drawing.Size(200, 50);
            btnNhanVien.Location = new System.Drawing.Point(80, 170);
            btnNhanVien.Click +=
                new System.EventHandler(
                this.btnNhanVien_Click);

            btnBanHang.Text = "Bán Hàng";
            btnBanHang.Size = new System.Drawing.Size(200, 50);
            btnBanHang.Location = new System.Drawing.Point(80, 240);
            btnBanHang.Click +=
                new System.EventHandler(
                this.btnBanHang_Click);

            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.Size = new System.Drawing.Size(200, 50);
            btnBaoCao.Location = new System.Drawing.Point(80, 310);
            btnBaoCao.Click +=
                new System.EventHandler(
                this.btnBaoCao_Click);

            this.Controls.Add(btnSanPham);
            this.Controls.Add(btnKhachHang);
            this.Controls.Add(btnNhanVien);
            this.Controls.Add(btnBanHang);
            this.Controls.Add(btnBaoCao);

            this.ClientSize =
                new System.Drawing.Size(360, 420);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "RETAIL SALES SYSTEM";
        }
    }

    partial class FrmSanPham
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label lblTim;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;

        private System.Windows.Forms.DataGridView dgvSanPham;

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
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();

            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();

            this.dgvSanPham = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();

            this.SuspendLayout();

            // lblMaSP
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(20, 20);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(78, 16);
            this.lblMaSP.Text = "Mã sản phẩm";

            // txtMaSP
            this.txtMaSP.Location = new System.Drawing.Point(120, 17);
            this.txtMaSP.Size = new System.Drawing.Size(200, 22);

            // lblTenSP
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(20, 60);
            this.lblTenSP.Text = "Tên sản phẩm";

            // txtTenSP
            this.txtTenSP.Location = new System.Drawing.Point(120, 57);
            this.txtTenSP.Size = new System.Drawing.Size(250, 22);

            // lblGiaBan
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(20, 100);
            this.lblGiaBan.Text = "Giá bán";

            // txtGiaBan
            this.txtGiaBan.Location = new System.Drawing.Point(120, 97);
            this.txtGiaBan.Size = new System.Drawing.Size(200, 22);

            // lblTonKho
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Location = new System.Drawing.Point(20, 140);
            this.lblTonKho.Text = "Tồn kho";

            // txtTonKho
            this.txtTonKho.Location = new System.Drawing.Point(120, 137);
            this.txtTonKho.Size = new System.Drawing.Size(200, 22);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(400, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(400, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(400, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // lblTim
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(20, 190);
            this.lblTim.Text = "Tìm kiếm";

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(120, 187);
            this.txtTimKiem.Size = new System.Drawing.Size(250, 22);

            // btnTim
            this.btnTim.Location = new System.Drawing.Point(400, 180);
            this.btnTim.Size = new System.Drawing.Size(100, 35);
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // dgvSanPham
            this.dgvSanPham.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvSanPham.Location =
                new System.Drawing.Point(20, 240);

            this.dgvSanPham.Name =
                "dgvSanPham";

            this.dgvSanPham.RowHeadersWidth = 51;

            this.dgvSanPham.Size =
                new System.Drawing.Size(750, 280);

            this.dgvSanPham.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                this.dgvSanPham_CellClick);

            // FrmSanPham
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 550);

            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTonKho);
            this.Controls.Add(this.lblTim);

            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.txtTimKiem);

            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);

            this.Controls.Add(this.dgvSanPham);

            this.Name = "FrmSanPham";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "QUẢN LÝ SẢN PHẨM";

            this.Load +=
                new System.EventHandler(
                this.FrmSanPham_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class FrmKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiem;

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiem;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.DataGridView dgvKhachHang;

        private void InitializeComponent()
        {
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();

            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.dgvKhachHang = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();

            this.SuspendLayout();

            lblMaKH.Text = "Mã KH";
            lblMaKH.Location = new System.Drawing.Point(30, 30);

            lblTenKH.Text = "Tên KH";
            lblTenKH.Location = new System.Drawing.Point(30, 70);

            lblSDT.Text = "SĐT";
            lblSDT.Location = new System.Drawing.Point(30, 110);

            lblDiem.Text = "Điểm";
            lblDiem.Location = new System.Drawing.Point(30, 150);

            txtMaKH.Location = new System.Drawing.Point(120, 25);
            txtTenKH.Location = new System.Drawing.Point(120, 65);
            txtSDT.Location = new System.Drawing.Point(120, 105);
            txtDiem.Location = new System.Drawing.Point(120, 145);

            btnThem.Text = "Thêm";
            btnThem.Location = new System.Drawing.Point(380, 25);
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            btnSua.Text = "Sửa";
            btnSua.Location = new System.Drawing.Point(380, 75);
            btnSua.Click += new System.EventHandler(this.btnSua_Click);

            btnXoa.Text = "Xóa";
            btnXoa.Location = new System.Drawing.Point(380, 125);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            dgvKhachHang.Location = new System.Drawing.Point(20, 220);
            dgvKhachHang.Size = new System.Drawing.Size(740, 250);

            this.Controls.Add(lblMaKH);
            this.Controls.Add(lblTenKH);
            this.Controls.Add(lblSDT);
            this.Controls.Add(lblDiem);

            this.Controls.Add(txtMaKH);
            this.Controls.Add(txtTenKH);
            this.Controls.Add(txtSDT);
            this.Controls.Add(txtDiem);

            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);

            this.Controls.Add(dgvKhachHang);

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
        }
    }

    partial class FrmNhanVien
    {
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtChucVu;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.DataGridView dgvNhanVien;

        private void InitializeComponent()
        {
            txtMaNV = new System.Windows.Forms.TextBox();
            txtTenNV = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            txtChucVu = new System.Windows.Forms.TextBox();

            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();

            dgvNhanVien = new System.Windows.Forms.DataGridView();

            txtMaNV.Location = new System.Drawing.Point(120, 20);
            txtTenNV.Location = new System.Drawing.Point(120, 60);
            txtSDT.Location = new System.Drawing.Point(120, 100);
            txtChucVu.Location = new System.Drawing.Point(120, 140);

            btnThem.Text = "Thêm";
            btnThem.Location = new System.Drawing.Point(420, 20);
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            btnSua.Text = "Sửa";
            btnSua.Location = new System.Drawing.Point(420, 70);
            btnSua.Click += new System.EventHandler(this.btnSua_Click);

            btnXoa.Text = "Xóa";
            btnXoa.Location = new System.Drawing.Point(420, 120);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            dgvNhanVien.Location = new System.Drawing.Point(20, 220);
            dgvNhanVien.Size = new System.Drawing.Size(740, 250);

            this.Controls.Add(txtMaNV);
            this.Controls.Add(txtTenNV);
            this.Controls.Add(txtSDT);
            this.Controls.Add(txtChucVu);

            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);

            this.Controls.Add(dgvNhanVien);

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
        }
    }

    partial class FrmBanHang
    {
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;

        private System.Windows.Forms.ComboBox cboKhachHang;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;

        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.DataGridView dgvGioHang;

        private void InitializeComponent()
        {
            txtMaSP = new System.Windows.Forms.TextBox();
            txtSoLuong = new System.Windows.Forms.TextBox();

            cboKhachHang = new System.Windows.Forms.ComboBox();

            btnThem = new System.Windows.Forms.Button();
            btnThanhToan = new System.Windows.Forms.Button();

            lblTongTien = new System.Windows.Forms.Label();

            dgvGioHang = new System.Windows.Forms.DataGridView();

            txtMaSP.Location = new System.Drawing.Point(30, 30);
            txtSoLuong.Location = new System.Drawing.Point(220, 30);

            cboKhachHang.Location = new System.Drawing.Point(30, 80);
            cboKhachHang.Width = 250;

            btnThem.Text = "Thêm Giỏ Hàng";
            btnThem.Location = new System.Drawing.Point(420, 25);
            btnThem.Click += new System.EventHandler(this.btnThem_Click);

            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.Location = new System.Drawing.Point(420, 75);
            btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            dgvGioHang.Location = new System.Drawing.Point(20, 150);
            dgvGioHang.Size = new System.Drawing.Size(740, 250);

            lblTongTien.Location = new System.Drawing.Point(20, 420);
            lblTongTien.AutoSize = true;
            lblTongTien.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 12F);

            lblTongTien.Text = "0";

            this.Controls.Add(txtMaSP);
            this.Controls.Add(txtSoLuong);
            this.Controls.Add(cboKhachHang);

            this.Controls.Add(btnThem);
            this.Controls.Add(btnThanhToan);

            this.Controls.Add(lblTongTien);
            this.Controls.Add(dgvGioHang);

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
        }
    }

    partial class FrmBaoCao
    {
        private System.Windows.Forms.Label lblDoanhThuNgay;
        private System.Windows.Forms.Label lblDoanhThuThang;

        private System.Windows.Forms.DataGridView dgvTop5;

        private void InitializeComponent()
        {
            lblDoanhThuNgay =
                new System.Windows.Forms.Label();

            lblDoanhThuThang =
                new System.Windows.Forms.Label();

            dgvTop5 =
                new System.Windows.Forms.DataGridView();

            lblDoanhThuNgay.Location =
                new System.Drawing.Point(30, 30);

            lblDoanhThuNgay.AutoSize = true;

            lblDoanhThuNgay.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    12F);

            lblDoanhThuNgay.Text =
                "0";

            lblDoanhThuThang.Location =
                new System.Drawing.Point(30, 80);

            lblDoanhThuThang.AutoSize = true;

            lblDoanhThuThang.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    12F);

            lblDoanhThuThang.Text =
                "0";

            dgvTop5.Location =
                new System.Drawing.Point(20, 150);

            dgvTop5.Size =
                new System.Drawing.Size(740, 250);

            this.Controls.Add(lblDoanhThuNgay);
            this.Controls.Add(lblDoanhThuThang);
            this.Controls.Add(dgvTop5);

            this.ClientSize =
                new System.Drawing.Size(800, 450);

            this.Text =
                "Báo Cáo Doanh Thu";

            this.Load +=
                new System.EventHandler(
                this.FrmBaoCao_Load);
        }
    }
}

