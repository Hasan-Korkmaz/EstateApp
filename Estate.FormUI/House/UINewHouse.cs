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
    public partial class UINewHouse : UserControl
    {
        public UINewHouse()
        {
            InitializeComponent();
        }
        Core.Adress.Adress adresCities = new Core.Adress.Adress();
        private void UINewHouse_Load(object sender, EventArgs e)
        {
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
            rdSaleTrue.Checked = true;

        }

       
        private void cmbCities_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDisc.Items.Clear();
            foreach (var item in adresCities.ListDisc(Application.StartupPath, cmbCities.SelectedItem.ToString()))
            {
                cmbDisc.Items.Add(item);
            }
            cmbDisc.SelectedIndex = 0;
        }

        private void rdSaleTrue_CheckedChanged(object sender, EventArgs e)
        {
                lblSell.Text = "Satış Fiyatı :";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdSaleFalse_CheckedChanged(object sender, EventArgs e)
        {
            lblSell.Text = "Depozito :";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(numSize.Value.ToString()) || String.IsNullOrWhiteSpace(numFloor.Value.ToString()) || String.IsNullOrWhiteSpace(numRoomCount.Value.ToString()) || String.IsNullOrWhiteSpace(numDoorNumber.Value.ToString()) || String.IsNullOrWhiteSpace(txtStreet.Text.ToString()))
            {
                MessageBox.Show("Boş değer girdisi algılandı lütfen değerleri kontrol ediniz", "Girdilerde Hata Tespit Edildi..");
            }
            else
            {
                Core.Adress.Adress Adress = new Core.Adress.Adress()
                {
                    City = cmbCities.SelectedItem.ToString(),
                    District = cmbDisc.SelectedItem.ToString(),
                    Street = txtStreet.Text,
                    DoorNumber = numDoorNumber.Value.ToString()
                };
                if (rdSaleTrue.Checked == true)
                {
                    Core.SaleHouse newSaleHouse = new Core.SaleHouse((int)numRoomCount.Value, (int)numFloor.Value, (double)numSize.Value, (Core.House.Type)cmbHouseType.SelectedItem, dateTimePicker1.Value, true, false, false,(double)numSellorDeposit.Value, Adress);
                    Core.Util.HaveHouses.getInstance().AddList(newSaleHouse);
                }
                else
                {
                    Core.RentHouse newRentHouse = new Core.RentHouse((int)numRoomCount.Value, (int)numFloor.Value, (double)numSize.Value, (Core.House.Type)cmbHouseType.SelectedItem, dateTimePicker1.Value,true,false,false,(double)numSellorDeposit.Value,Adress);
                    Core.Util.HaveHouses.getInstance().AddList(newRentHouse);
                }
                MessageBox.Show("Ev Kaydedildi");

            }
        }

     
    }
}
