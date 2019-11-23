using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.House
{
    public partial class UiEditHouse : Form
    {
        byte houseType;
        string privateNumber;
        Core.Util.HaveHouses have = Core.Util.HaveHouses.getInstance();
        Core.Adress.Adress adresCities = new Core.Adress.Adress();
        public UiEditHouse(string privateNumber, byte houseType)
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




            this.houseType = houseType;
            this.privateNumber = privateNumber;
            if (houseType == 0)
            {
                have.FindRent(privateNumber);
                lblSell.Text = "Depozitosu : ";
                numRoomCount.Value = have.FindRent(privateNumber).RoomCount;
                numFloor.Value = have.FindRent(privateNumber).FloorNumber;
                numSize.Value = (decimal)have.FindRent(privateNumber).HouseSize;
                dateTimePicker1.Value = have.FindRent(privateNumber).BuildDate;
                cmbHouseType.SelectedItem = have.FindRent(privateNumber).HouseType;
                cmbCities.SelectedItem = have.FindRent(privateNumber).Adress.City;
                cmbDisc.SelectedItem= have.FindRent(privateNumber).Adress.District;
                txtStreet.Text= have.FindRent(privateNumber).Adress.Street;
                numDoorNumber.Value =decimal.Parse(have.FindRent(privateNumber).Adress.DoorNumber);
                numSellorDeposit.Value=(decimal)  have.FindRent(privateNumber).RentDeposit;
                numRentPrice.Value = (decimal)have.FindRent(privateNumber).RentPrice;

            }
            else if (houseType == 1)
            {
                lblRentPrice.Visible = false;
                numRentPrice.Visible = false;
               

                have.FindSale(privateNumber);
                numRoomCount.Value = have.FindSale(privateNumber).RoomCount;
                numFloor.Value = have.FindSale(privateNumber).FloorNumber;
                numSize.Value = (decimal)have.FindSale(privateNumber).HouseSize;
                dateTimePicker1.Value = have.FindSale(privateNumber).BuildDate;
                cmbHouseType.SelectedItem = have.FindSale(privateNumber).HouseType;
                cmbCities.SelectedItem = have.FindSale(privateNumber).Adress.City;
                cmbDisc.SelectedItem = have.FindSale(privateNumber).Adress.District;
                txtStreet.Text = have.FindSale(privateNumber).Adress.Street;
                numDoorNumber.Value = decimal.Parse(have.FindSale(privateNumber).Adress.DoorNumber);
                numSellorDeposit.Value = (decimal)have.FindSale(privateNumber).SalePrice;
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(numSize.Value.ToString()) || String.IsNullOrWhiteSpace(numFloor.Value.ToString()) || String.IsNullOrWhiteSpace(numRoomCount.Value.ToString()) || String.IsNullOrWhiteSpace(numDoorNumber.Value.ToString()) || String.IsNullOrWhiteSpace(txtStreet.Text.ToString()))
            {
                MessageBox.Show("Boş değer girdisi algılandı lütfen değerleri kontrol ediniz", "Girdilerde Hata Tespit Edildi..");
            }
            else
            {
                Core.RentHouse rt = have.FindRent(privateNumber);
                Core.SaleHouse sl = have.FindSale(privateNumber);
                Core.Adress.Adress Adress = new Core.Adress.Adress()
                {
                    City = cmbCities.SelectedItem.ToString(),
                    District = cmbDisc.SelectedItem.ToString(),
                    Street = txtStreet.Text,
                    DoorNumber = numDoorNumber.Value.ToString()
                };

                if (houseType == 0)
                {
                    rt.RoomCount = (int)numRoomCount.Value;
                    rt.FloorNumber = (int)numFloor.Value;
                    rt.HouseSize = (int)numSize.Value;
                    rt.BuildDate = (DateTime)dateTimePicker1.Value;
                    rt.HouseType = (Core.House.Type)cmbHouseType.SelectedItem;
                    rt.RentPrice = (double)numRentPrice.Value;
                    rt.RentDeposit = (double)numSellorDeposit.Value;
                    rt.Adress = null;
                    rt.Adress = Adress;
                }
                else
                {
                    sl.RoomCount = (int)numRoomCount.Value;
                    sl.FloorNumber = (int)numFloor.Value;
                    sl.HouseSize = (int)numSize.Value;
                    sl.BuildDate = (DateTime)dateTimePicker1.Value;
                    sl.HouseType = (Core.House.Type)cmbHouseType.SelectedItem;
                    sl.SalePrice = (double)numSellorDeposit.Value;
                    sl.Adress = null;
                    sl.Adress = Adress;
                }
                MessageBox.Show("Ürün başarılı bir şekilde düzenlendi...", "Düzenleme başarılı olmuştur");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (houseType == 0)
            {
                Process.Start(have.FindRent(privateNumber).AppPath);

            }
            else if (houseType == 1)
            {
                Process.Start(have.FindSale(privateNumber).AppPath);
            }
        }
    }
}
