using QuanLyHinh.DAO;
using QuanLyHinh.Models;

namespace QuanLyHinh.GUI
{
    public partial class Form1 : Form
    {
        private HinhDAO hinhDAO;
        int index = -1;

        public void InjectHinhDAO(HinhDAO x)
        {
            this.hinhDAO = x;
        }

        public Form1()
        {
            InitializeComponent();

            grpTron.Top = grpCN.Top;
            grpTron.Left = grpCN.Left;

            //hinhDAO = new HinhDAO("D:\\New folder\\Data\\dotNET-S5\\Ngay6\\QuanLyHinh\\Data.txt");
        }

        private void btnNapDanhSach_Click(object sender, EventArgs e)
        {
            var lst = hinhDAO.ReadHinhFromFile();

            bsHinh.DataSource = lst;
            gridHinh.AutoGenerateColumns = false;
            gridHinh.DataSource = bsHinh;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnNapDanhSach_Click(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region Không sử dụng binding source
            //// Xác định đối tượng đang chọn...
            //var x = lbxHinh.SelectedItem as Hinh;

            //// Xoá nó khỏi listbox
            //lbxHinh.Items.Remove(x);

            //// Save danh sách ở listbox xuống file
            //// ... 
            #endregion

            #region Sử dụng binding source
            // Xác định đối tượng đang chọn...
            //var x = bsHinh.Current as Hinh;

            // Xoá nó khỏi bsHinh
            bsHinh.RemoveCurrent();

            // Save danh sách ở listbox xuống file
            var lst = bsHinh.DataSource as List<Hinh>;

            hinhDAO.SaveHinhToFile(lst);
            #endregion

        }

        private void bsHinh_CurrentChanged(object sender, EventArgs e)
        {

            if (bsHinh.Current == null)
            {
                txtCN_VatLieu.Text = "";
                txtCN_ChieuDai.Text = "";
                txtCN_ChieuRong.Text = "";

                txtT_VatLieu.Text = "";
                txtT_BanKinh.Text = "";
                return;
            }


            // Xác định đối tượng đang được chọn (highlight) ở trên listbox...
            Hinh x;
            x = bsHinh.Current as Hinh;

            // ... hiển thị thông tin đối tượng này lên txtDoiTuongDuocChon
            // Cách 1

            
            // Cách 2 -- Hiển thị thông tin chi tiết ra groupbox
            grpTron.Visible = false;
            grpCN.Visible = false;

            if (x is HinhTron)
            {
                grpTron.Visible = true;
                var x2 = x as HinhTron;
                if (x2 != null)
                {
                    txtT_VatLieu.Text = x2.VatLieu;
                    txtT_BanKinh.Text = $"{x2.BanKinh:F2}";
                }
            }
            else
            {
                grpCN.Visible = true;
                var x2 = x as HinhChuNhat;
                if (x2 != null)
                {
                    txtCN_VatLieu.Text = x2.VatLieu;
                    txtCN_ChieuDai.Text = $"{x2.ChieuDai:F2}";
                    txtCN_ChieuRong.Text = $"{x2.ChieuRong:F2}";
                }
            }
        }

        private void grbHT_Enter(object sender, EventArgs e)
        {

        }

        private void hìnhChữNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHinhChuNhat_BoSung frm = new FormHinhChuNhat_BoSung();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                var hinhCNMoi = frm.HinhChuNhatKetQua;
                bsHinh.Add(hinhCNMoi);

                var lst = bsHinh.DataSource as List<Hinh>;
                hinhDAO.SaveHinhToFile(lst);

            }
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHinhTron_BoSung frm = new FormHinhTron_BoSung();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                var hinhTronMoi = frm.HinhTronKetQua;
                bsHinh.Add(hinhTronMoi);

                var lst = bsHinh.DataSource as List<Hinh>;
                hinhDAO.SaveHinhToFile(lst);                      
            }
        }
    }
}
