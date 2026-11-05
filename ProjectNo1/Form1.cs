using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            f.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            FrmBanHang f = new FrmBanHang();
            f.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
        }
    }

    public partial class FrmSanPham : Form
    {
        SanPhamBUS bus = new SanPhamBUS();

        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSanPham.DataSource =
                bus.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();

            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.GiaBan = decimal.Parse(txtGiaBan.Text);
            sp.SoLuongTon = int.Parse(txtTonKho.Text);

            if (bus.Insert(sp))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();

            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.GiaBan = decimal.Parse(txtGiaBan.Text);
            sp.SoLuongTon = int.Parse(txtTonKho.Text);

            if (bus.Update(sp))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus.Delete(txtMaSP.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource =
                bus.Search(txtTimKiem.Text);
        }

        private void dgvSanPham_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            txtMaSP.Text =
                dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();

            txtTenSP.Text =
                dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();

            txtGiaBan.Text =
                dgvSanPham.CurrentRow.Cells["GiaBan"].Value.ToString();

            txtTonKho.Text =
                dgvSanPham.CurrentRow.Cells["SoLuongTon"].Value.ToString();
        }
    }

    public partial class FrmKhachHang : Form
    {
        KhachHangBUS bus =
            new KhachHangBUS();

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(
            object sender,
            EventArgs e)
        {
            dgvKhachHang.DataSource =
                bus.GetAll();
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            KhachHangDTO kh =
                new KhachHangDTO();

            kh.TenKH = txtTenKH.Text;
            kh.DienThoai = txtSDT.Text;

            bus.Insert(kh);

            dgvKhachHang.DataSource =
                bus.GetAll();
        }

        private void btnSua_Click(
            object sender,
            EventArgs e)
        {
            KhachHangDTO kh =
                new KhachHangDTO();

            kh.MaKH =
                int.Parse(txtMaKH.Text);

            kh.TenKH = txtTenKH.Text;

            kh.DienThoai = txtSDT.Text;

            kh.DiemTichLuy =
                int.Parse(txtDiem.Text);

            bus.Update(kh);

            dgvKhachHang.DataSource =
                bus.GetAll();
        }

        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            bus.Delete(
                int.Parse(txtMaKH.Text));

            dgvKhachHang.DataSource =
                bus.GetAll();
        }
    }

    public partial class FrmNhanVien : Form
    {
        NhanVienBUS bus =
            new NhanVienBUS();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(
            object sender,
            EventArgs e)
        {
            dgvNhanVien.DataSource =
                bus.GetAll();
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            NhanVienDTO nv =
                new NhanVienDTO();

            nv.TenNV = txtTenNV.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.ChucVu = txtChucVu.Text;

            bus.Insert(nv);

            dgvNhanVien.DataSource =
                bus.GetAll();
        }

        private void btnSua_Click(
            object sender,
            EventArgs e)
        {
            NhanVienDTO nv =
                new NhanVienDTO();

            nv.MaNV =
                int.Parse(txtMaNV.Text);

            nv.TenNV = txtTenNV.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.ChucVu = txtChucVu.Text;

            bus.Update(nv);

            dgvNhanVien.DataSource =
                bus.GetAll();
        }

        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            bus.Delete(
                int.Parse(txtMaNV.Text));

            dgvNhanVien.DataSource =
                bus.GetAll();
        }
    }

    public partial class FrmBanHang : Form
    {
        HoaDonBUS busHD =
    new HoaDonBUS();

        DataTable gioHang =
            new DataTable();

        private void FrmBanHang_Load(object sender,EventArgs e)
        {
            gioHang.Columns.Add("MaSP");
            gioHang.Columns.Add("DonGia");
            gioHang.Columns.Add("SoLuong");
            gioHang.Columns.Add("ThanhTien");

            dgvGioHang.DataSource =
                gioHang;
        }

        private void btnThem_Click(object sender,EventArgs e)
        {
            string maSP =
                txtMaSP.Text;

            int sl =
                int.Parse(txtSoLuong.Text);

            decimal gia = 100000;

            DataRow row =
                gioHang.NewRow();

            row["MaSP"] = maSP;
            row["DonGia"] = gia;
            row["SoLuong"] = sl;
            row["ThanhTien"] = gia * sl;

            gioHang.Rows.Add(row);

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataRow row in gioHang.Rows)
            {
                tong +=
                Convert.ToDecimal(
                row["ThanhTien"]);
            }

            lblTongTien.Text =
            tong.ToString("N0");
        }

        private void btnThanhToan_Click(
    object sender,
    EventArgs e)
        {
            decimal tongTien = 0;

            foreach (DataRow row
                in gioHang.Rows)
            {
                tongTien +=
                    Convert.ToDecimal(
                    row["ThanhTien"]);
            }

            bool result =
                busHD.ThanhToan(
                1,
                1,
                gioHang,
                tongTien);

            if (result)
            {
                MessageBox.Show(
                    "Thanh toán thành công");

                gioHang.Clear();

                lblTongTien.Text = "0";
            }
            else
            {
                MessageBox.Show(
                    "Thanh toán thất bại");
            }
        }
    }

    public partial class FrmBaoCao : Form
    {
        HoaDonBUS bus =
            new HoaDonBUS();

        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(
            object sender,
            EventArgs e)
        {
            lblDoanhThuNgay.Text =
                bus.DoanhThuNgay()
                .ToString("N0");

            lblDoanhThuThang.Text =
                bus.DoanhThuThang()
                .ToString("N0");

            dgvTop5.DataSource =
                bus.Top5SanPham();
        }
    }
}

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
    }

    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DienThoai { get; set; }
        public int DiemTichLuy { get; set; }
    }

    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SoDienThoai { get; set; }
        public string ChucVu { get; set; }
    }
}

namespace DAL
{
    public class DBConnection
    {
        protected SqlConnection conn =
             new SqlConnection(
             @"Data Source=TRUNGHIEU\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True");
    }

    public class SanPhamDAL : DBConnection
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM SanPham", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public bool Insert(SanPhamDTO sp)
        {
            string sql =
            @"INSERT INTO SanPham
            VALUES(@MaSP,@TenSP,@GiaBan,@SoLuongTon)";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);

            conn.Open();
            int kq = cmd.ExecuteNonQuery();
            conn.Close();

            return kq > 0;
        }

        public bool Update(SanPhamDTO sp)
        {
            string sql =
            @"UPDATE SanPham
            SET TenSP=@TenSP,
                GiaBan=@GiaBan,
                SoLuongTon=@SoLuongTon
            WHERE MaSP=@MaSP";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);

            conn.Open();
            int kq = cmd.ExecuteNonQuery();
            conn.Close();

            return kq > 0;
        }

        public bool Delete(string maSP)
        {
            string sql =
            @"DELETE FROM SanPham
            WHERE MaSP=@MaSP";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSP", maSP);

            conn.Open();
            int kq = cmd.ExecuteNonQuery();
            conn.Close();

            return kq > 0;
        }

        public DataTable Search(string keyword)
        {
            string sql =
            @"SELECT *
              FROM SanPham
              WHERE MaSP LIKE @key
              OR TenSP LIKE @key";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue(
                "@key",
                "%" + keyword + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }

    public class KhachHangDAL : DBConnection
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM KhachHang",
                conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public bool Insert(KhachHangDTO kh)
        {
            string sql =
            @"INSERT INTO KhachHang
            (TenKH,DienThoai,DiemTichLuy)
            VALUES
            (@TenKH,@DT,@Diem)";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@DT", kh.DienThoai);
            cmd.Parameters.AddWithValue("@Diem", kh.DiemTichLuy);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        public bool Update(KhachHangDTO kh)
        {
            string sql =
            @"UPDATE KhachHang
              SET TenKH=@TenKH,
                  DienThoai=@DT,
                  DiemTichLuy=@Diem
              WHERE MaKH=@MaKH";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@DT", kh.DienThoai);
            cmd.Parameters.AddWithValue("@Diem", kh.DiemTichLuy);
            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        public bool Delete(int maKH)
        {
            string sql =
                "DELETE FROM KhachHang WHERE MaKH=@MaKH";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKH", maKH);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }
    }

    public class NhanVienDAL : DBConnection
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM NhanVien",
                conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public bool Insert(NhanVienDTO nv)
        {
            string sql =
            @"INSERT INTO NhanVien
            (TenNV,SoDienThoai,ChucVu)
            VALUES
            (@Ten,@SDT,@CV)";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", nv.TenNV);
            cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@CV", nv.ChucVu);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        public bool Update(NhanVienDTO nv)
        {
            string sql =
            @"UPDATE NhanVien
              SET TenNV=@Ten,
                  SoDienThoai=@SDT,
                  ChucVu=@CV
              WHERE MaNV=@MaNV";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", nv.TenNV);
            cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@CV", nv.ChucVu);
            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }

        public bool Delete(int maNV)
        {
            string sql =
                "DELETE FROM NhanVien WHERE MaNV=@MaNV";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", maNV);

            conn.Open();

            int kq = cmd.ExecuteNonQuery();

            conn.Close();

            return kq > 0;
        }
    }

    public class HoaDonDAL : DBConnection
    {
        public bool ThanhToan(
            int maNV,
            int? maKH,
            DataTable gioHang,
            decimal tongTien)
        {
            conn.Open();

            SqlTransaction trans =
                conn.BeginTransaction();

            try
            {
                string sqlHD =
                @"INSERT INTO HoaDon
                (MaNV,MaKH,TongTien)
                VALUES(@MaNV,@MaKH,@TongTien);

                SELECT SCOPE_IDENTITY()";

                SqlCommand cmdHD =
                    new SqlCommand(
                    sqlHD,
                    conn,
                    trans);

                cmdHD.Parameters.AddWithValue("@MaNV", maNV);

                if (maKH == null)
                    cmdHD.Parameters.AddWithValue(
                        "@MaKH",
                        DBNull.Value);
                else
                    cmdHD.Parameters.AddWithValue(
                        "@MaKH",
                        maKH);

                cmdHD.Parameters.AddWithValue(
                    "@TongTien",
                    tongTien);

                int maHD =
                    Convert.ToInt32(
                    cmdHD.ExecuteScalar());

                foreach (DataRow row in gioHang.Rows)
                {
                    string maSP =
                        row["MaSP"].ToString();

                    int sl =
                        Convert.ToInt32(
                        row["SoLuong"]);

                    decimal gia =
                        Convert.ToDecimal(
                        row["DonGia"]);

                    SqlCommand check =
                        new SqlCommand(
                        @"SELECT SoLuongTon
                        FROM SanPham
                        WHERE MaSP=@MaSP",
                        conn,
                        trans);

                    check.Parameters.AddWithValue(
                        "@MaSP",
                        maSP);

                    int ton =
                        Convert.ToInt32(
                        check.ExecuteScalar());

                    if (ton < sl)
                    {
                        trans.Rollback();

                        return false;
                    }

                    SqlCommand cthd =
                        new SqlCommand(
                        @"INSERT INTO ChiTietHoaDon
                        VALUES
                        (@MaHD,@MaSP,@SL,@Gia)",
                        conn,
                        trans);

                    cthd.Parameters.AddWithValue("@MaHD", maHD);
                    cthd.Parameters.AddWithValue("@MaSP", maSP);
                    cthd.Parameters.AddWithValue("@SL", sl);
                    cthd.Parameters.AddWithValue("@Gia", gia);

                    cthd.ExecuteNonQuery();

                    SqlCommand updateKho =
                        new SqlCommand(
                        @"UPDATE SanPham
                        SET SoLuongTon =
                            SoLuongTon - @SL
                        WHERE MaSP=@MaSP",
                        conn,
                        trans);

                    updateKho.Parameters.AddWithValue("@SL", sl);
                    updateKho.Parameters.AddWithValue("@MaSP", maSP);

                    updateKho.ExecuteNonQuery();
                }

                if (maKH != null)
                {
                    SqlCommand diem =
                        new SqlCommand(
                        @"UPDATE KhachHang
                        SET DiemTichLuy =
                        DiemTichLuy + @Diem
                        WHERE MaKH=@MaKH",
                        conn,
                        trans);

                    diem.Parameters.AddWithValue(
                        "@Diem",
                        (int)(tongTien / 100000));

                    diem.Parameters.AddWithValue(
                        "@MaKH",
                        maKH);

                    diem.ExecuteNonQuery();
                }

                trans.Commit();

                return true;
            }
            catch
            {
                trans.Rollback();

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public decimal DoanhThuNgay()
        {
            string sql =
            @"SELECT ISNULL(
            SUM(TongTien),0)
            FROM HoaDon
            WHERE CAST(NgayLap AS DATE)
            = CAST(GETDATE() AS DATE)";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            conn.Open();

            decimal tong =
                Convert.ToDecimal(
                cmd.ExecuteScalar());

            conn.Close();

            return tong;
        }

        public decimal DoanhThuThang()
        {
            string sql =
            @"SELECT ISNULL(
            SUM(TongTien),0)
            FROM HoaDon
            WHERE MONTH(NgayLap)=MONTH(GETDATE())
            AND YEAR(NgayLap)=YEAR(GETDATE())";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            conn.Open();

            decimal tong =
                Convert.ToDecimal(
                cmd.ExecuteScalar());

            conn.Close();

            return tong;
        }

        public DataTable Top5SanPham()
        {
            string sql =
            @"SELECT TOP 5
                SP.MaSP,
                SP.TenSP,
                SUM(CT.SoLuong) TongBan
            FROM ChiTietHoaDon CT
            INNER JOIN SanPham SP
            ON SP.MaSP=CT.MaSP
            GROUP BY SP.MaSP,SP.TenSP
            ORDER BY TongBan DESC";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, conn);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                return false;

            if (string.IsNullOrWhiteSpace(sp.TenSP))
                return false;

            if (sp.GiaBan <= 0)
                return false;

            if (sp.SoLuongTon < 0)
                return false;

            return dal.Insert(sp);
        }

        public bool Update(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                return false;

            if (string.IsNullOrWhiteSpace(sp.TenSP))
                return false;

            if (sp.GiaBan <= 0)
                return false;

            if (sp.SoLuongTon < 0)
                return false;

            return dal.Update(sp);
        }

        public bool Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                return false;

            return dal.Delete(maSP);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }

    public class KhachHangBUS
    {
        private KhachHangDAL dal =
            new KhachHangDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                return false;

            return dal.Insert(kh);
        }

        public bool Update(KhachHangDTO kh)
        {
            if (kh.MaKH <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(kh.TenKH))
                return false;

            return dal.Update(kh);
        }

        public bool Delete(int maKH)
        {
            if (maKH <= 0)
                return false;

            return dal.Delete(maKH);
        }
    }

    public class NhanVienBUS
    {
        private NhanVienDAL dal =
            new NhanVienDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                return false;

            return dal.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(nv.TenNV))
                return false;

            return dal.Update(nv);
        }

        public bool Delete(int maNV)
        {
            if (maNV <= 0)
                return false;

            return dal.Delete(maNV);
        }
    }

    public class HoaDonBUS
    {
        private HoaDonDAL dal =
            new HoaDonDAL();

        public bool ThanhToan(
            int maNV,
            int? maKH,
            DataTable gioHang,
            decimal tongTien)
        {
            if (maNV <= 0)
                return false;

            if (gioHang == null)
                return false;

            if (gioHang.Rows.Count == 0)
                return false;

            if (tongTien <= 0)
                return false;

            return dal.ThanhToan(
                maNV,
                maKH,
                gioHang,
                tongTien);
        }

        public decimal DoanhThuNgay()
        {
            return dal.DoanhThuNgay();
        }

        public decimal DoanhThuThang()
        {
            return dal.DoanhThuThang();
        }

        public DataTable Top5SanPham()
        {
            return dal.Top5SanPham();
        }
    }
}
