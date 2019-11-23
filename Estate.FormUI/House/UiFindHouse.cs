using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.House
{
    public partial class UiFindHouse : UserControl
    {
        Core.Adress.Adress adresCities = new Core.Adress.Adress();
        Core.Util.HaveHouses have = Core.Util.HaveHouses.getInstance();
        string privateNumber;

        public UiFindHouse()
        {
            InitializeComponent();

            cmbHouseType.Items.Add(Core.House.Type.Daire);
            cmbHouseType.Items.Add(Core.House.Type.Bahçeli);
            cmbHouseType.Items.Add(Core.House.Type.Dubleks);
            cmbHouseType.Items.Add(Core.House.Type.Müstakil);
            foreach (string item in adresCities.ListCity(Application.StartupPath))
            {
                cmbCities.Items.Add(item);
            }

            cmbHouseType.SelectedIndex = 2;
            cmbCities.SelectedIndex = 0;
            cmbDisc.SelectedIndex = 0;
            rdSale.Checked = true;
        }

        private void rdSale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSale.Checked == true)
            {
                lblMin.Text = "Fiyat Min :";
                lblMax.Text = "Fiyat Max : ";
                pnlDeposit.Visible = false;
                btnFind.Location = new Point(pnlDeposit.Location.X + 20, pnlDeposit.Location.Y + 8);
            }
            else
            {
                lblMin.Text = "Kira Min :";
                lblMax.Text = "Kira Max : ";
                pnlDeposit.Visible = true;
                btnFind.Location = new Point(1090, 20);
            }

        }


        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDisc.Items.Clear();
            foreach (var item in adresCities.ListDisc(Application.StartupPath, cmbCities.SelectedItem.ToString()))
            {
                cmbDisc.Items.Add(item);
            }
            cmbDisc.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Core.SaleHouse> filterSaleHouse;
            bool isArchive = false;
            if (chIsArchive.Checked == true)
            {
                isArchive = true;
            }
            if (numMax.Value == 0)
            {
                numMax.Value = 9999999;
            }
            if (numDepositMax.Value == 0)
            {
                numDepositMax.Value = 9999999;
            }

            if (rdSale.Checked == true && (!(cmbCities.SelectedItem==null) && !(cmbDisc.SelectedItem==null)&& !(cmbHouseType.SelectedItem==null)) )
            {
                dgvHouseList.Columns.Clear();
                dgvHouseList.Columns.Add("Guid", "Benzersiz Kimlik");
                dgvHouseList.Columns.Add("BuildDate", "Bina Yapım Tarihi");
                dgvHouseList.Columns.Add("HouseType", "Ev Tipi");
                dgvHouseList.Columns.Add("RoomCount", "Oda Sayısı");
                dgvHouseList.Columns.Add("BuildAge", "Bina Yaşı");
                dgvHouseList.Columns.Add("HouseSize", "Evin Boyutu");
                dgvHouseList.Columns.Add("FloorNumber", "Kat Numarası");
                dgvHouseList.Columns.Add("Adress", "Adresi");
                dgvHouseList.Columns.Add("SalePrice", "Satış Fiyatı");
                dgvHouseList.Columns["Guid"].Visible = false;

                filterSaleHouse = have.SaleHouseList().Where(x => (x.HouseType == (Core.House.Type)cmbHouseType.SelectedItem) && x.RoomCount >= numRoomCount.Value && x.HouseSize >= (double)numSize.Value && x.SalePrice >= (double)(numMin.Value) && x.SalePrice <= (double)(numMax.Value) && x.Adress.City == cmbCities.SelectedItem.ToString() && x.Adress.District == cmbDisc.SelectedItem.ToString() && x.IsArchive == isArchive && x.IsDelete == false).ToList();
                foreach (Core.SaleHouse item in filterSaleHouse)
                {
                    dgvHouseList.Rows.Add(item.PrivateNumber, item.BuildDate, item.HouseType, item.RoomCount, item.BuildingAge, item.HouseSize + "m²", item.FloorNumber + ".Kat", item.Adress.ToString(), item.SalePrice.ToString("#,##0") + " TL");
                }

            }
            else if (rdRent.Checked == true && (!(cmbCities.SelectedItem == null) && !(cmbDisc.SelectedItem == null) && !(cmbHouseType.SelectedItem == null)))
            {
                List<Core.RentHouse> filterRentHouse;
                dgvHouseList.Columns.Clear();
                dgvHouseList.Columns.Add("Guid", "Benzersiz Kimlik");
                dgvHouseList.Columns.Add("BuildDate", "Bina Yapım Tarihi");
                dgvHouseList.Columns.Add("HouseType", "Ev Tipi");
                dgvHouseList.Columns.Add("RoomCount", "Oda Sayısı");
                dgvHouseList.Columns.Add("BuildAge", "Bina Yaşı");
                dgvHouseList.Columns.Add("HouseSize", "Evin Boyutu");
                dgvHouseList.Columns.Add("FloorNumber", "Kat Numarası");
                dgvHouseList.Columns.Add("Adress", "Adresi");
                dgvHouseList.Columns.Add("rentPrice", "Kira Fiyatı");
                dgvHouseList.Columns.Add("rentDeposit", "Depozitosu");
                dgvHouseList.Columns["Guid"].Visible = false;
                filterRentHouse = have.RentHouseList().Where(x => (x.HouseType == (Core.House.Type)cmbHouseType.SelectedItem) && x.RoomCount >= numRoomCount.Value && x.HouseSize>=(double)numSize.Value && x.RentPrice >= (double)(numMin.Value) && x.RentPrice <= (double)(numMax.Value) && x.Adress.City == cmbCities.SelectedItem.ToString() && x.Adress.District == cmbDisc.SelectedItem.ToString() && x.RentDeposit >= (double)numDepositMin.Value && x.RentDeposit <= (double)numDepositMax.Value && x.IsArchive == isArchive && x.IsDelete == false).ToList();
                foreach (Core.RentHouse item in filterRentHouse)
                {
                    dgvHouseList.Rows.Add(item.PrivateNumber, item.BuildDate, item.HouseType, item.RoomCount, item.BuildingAge, item.HouseSize + " m²", item.FloorNumber + ".Kat", item.Adress.ToString(), item.RentPrice + " TL", item.RentDeposit.ToString("#,##0") + " TL");
                }
            }
            else
            {
                MessageBox.Show("Girdilerde Hata Oluştu","Sorguda Hata");
            }
        }

        private void UiFindHouse_Load(object sender, EventArgs e)
        {

        }

        private void dgvHouseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            privateNumber = dgvHouseList.CurrentRow.Cells["Guid"].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(privateNumber == null))
            {
                int state = 0;
                DialogResult dialogStatus = MessageBox.Show("Bu evi gerçekten silmek istiyor musunuz?", "Onay Al", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogStatus == DialogResult.Yes)
                {
                    if (rdRent.Checked == true)
                    {
                        state = have.RemoveRentHouse(privateNumber);
                    }
                    else if (rdSale.Checked == true)
                    {
                        state = have.RemoveSaleHouse(privateNumber);
                    }
                    if (state == 1)
                    {
                        MessageBox.Show("Ev Başarıyla Silindi...", "Silme İşlemi");
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi...", "İşlem Başarısız");

                }
            }
            else
            {
                MessageBox.Show("Listeden Bir Öğe Seçiniz", "İşlem Başarısız");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!(privateNumber == null))
            {
                if (rdRent.Checked == true)
                {
                    UiShowHouse show = new UiShowHouse(privateNumber, 0);
                    show.ShowDialog();

                }
                else if (rdSale.Checked == true)
                {
                    UiShowHouse show = new UiShowHouse(privateNumber, 1);
                    show.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Listeden Bir Öğe Seçiniz");
            }
            privateNumber = null;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!(privateNumber == null))
            {
                if (rdRent.Checked == true)
                {
                    UiEditHouse edit = new UiEditHouse(privateNumber, 0);
                    edit.ShowDialog();

                }
                else if (rdSale.Checked == true)
                {
                    UiEditHouse edit = new UiEditHouse(privateNumber, 1);
                    edit.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Listeden Bir Öğe Seçiniz");
            }
            privateNumber = null;
        }
    }
}
