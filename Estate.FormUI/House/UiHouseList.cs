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
    public partial class UiHouseList : UserControl
    {
        Core.Util.HaveHouses haveHouses = Core.Util.HaveHouses.getInstance();
        public UiHouseList()
        {
            InitializeComponent();
            dgvHouseList.Columns.Add("Guid","Benzersiz Kimlik");
            dgvHouseList.Columns.Add("BuildDate","Bina Yapım Tarihi");
            dgvHouseList.Columns.Add("HouseType","Ev Tipi");
            dgvHouseList.Columns.Add("RoomCount","Oda Sayısı");
            dgvHouseList.Columns.Add("BuildAge","Bina Yaşı");
            dgvHouseList.Columns.Add("HouseSize","Evin Boyutu");
            dgvHouseList.Columns.Add("FloorNumber","Kat Numarası");
            dgvHouseList.Columns.Add("Adress", "Adresi");
            dgvHouseList.Columns.Add("RentDeposit", "Depozitosu");
            dgvHouseList.Columns.Add("RentPrice", "Kirası");
            foreach (var item in haveHouses.RentHouseList())
            {
               
                    dgvHouseList.Rows.Add(item.PrivateNumber, item.BuildDate, item.HouseType,item.RoomCount, item.BuildingAge, item.HouseSize+ "m²", item.FloorNumber+".Kat", item.Adress.ToString(), ((Core.RentHouse)item).RentDeposit+" TL", ((Core.RentHouse)item).RentPrice+" TL");
                /*
                else if (item.GetType() == typeof(Core.SaleHouse))
                {
                    dgvHouseList.Rows.Add(item.PrivateNumber, item.BuildDate, item.HouseType,item.RoomCount, item.BuildingAge, item.HouseSize + "m²", item.FloorNumber+".Kat", item.Adress.ToString(), "Kiralık Değil", "Kiralık Değil", ((Core.SaleHouse)item).SalePrice+" TL");

                }*/
            }



        }
    }
}
