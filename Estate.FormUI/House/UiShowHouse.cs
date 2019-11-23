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
    public partial class UiShowHouse : Form
    {
        string privateNumber;
        byte listType;
        Core.Util.HaveHouses have = Core.Util.HaveHouses.getInstance();
        


        public UiShowHouse(string privateNumber, byte listType)
        {
            InitializeComponent();
            this.listType = listType;
            this.privateNumber = privateNumber;
            if (listType == 0)
            {
                have.FindRent(privateNumber);
                lblRoomCount.Text = "Oda Sayısı : " + have.FindRent(privateNumber).RoomCount;
                lblFloorNumber.Text="Kat Numarası : "+ have.FindRent(privateNumber).FloorNumber+".Kat";
                lblHouseSize.Text="Evin Genişliği : "+ have.FindRent(privateNumber).HouseSize + " m²";
                lblBuildDate.Text="Yapım Yılı : "+ String.Format("{0:d/M/yyyy}", have.FindRent(privateNumber).BuildDate); 
                lblAge.Text = "Evin Yaşı : " + have.FindRent(privateNumber).BuildingAge;
                lblHouseType.Text="Evin Tipi : "+ have.FindRent(privateNumber).HouseType;
                lblCity.Text = "Şehir : " + have.FindRent(privateNumber).Adress.City;
                lblDisc.Text = "İlçe : " + have.FindRent(privateNumber).Adress.District;
                lblStreet.Text="Cadde/Sokak : " + have.FindRent(privateNumber).Adress.Street;
                lblDoorNumber.Text="Kapı Numarası : "+ have.FindRent(privateNumber).Adress.DoorNumber;
                lblSellorDeposit.Text = "Depozitosu : " + have.FindRent(privateNumber).RentDeposit + " TL";
                lblRentPrice.Text = "Kira Fiyatı : " + have.FindRent(privateNumber).RentPrice + " TL";
                if (have.FindRent(privateNumber).IsArchive == true)
                {
                    lblArchive.Text += " Evet";
                    btnArchive.Text = "Arşiv Kaldır";
                }
                else
                {
                    lblArchive.Text += " Hayır";
                    btnArchive.Text = "Arşivle";
                }

            }
           else if (listType == 1)
            {
                btnContainer.Location = new Point(btnContainer.Location.X, lblArchive.Location.Y);
                lblArchive.Location = new Point(lblArchive.Location.X, lblSellorDeposit.Location.Y);
                lblSellorDeposit.Location = new Point(lblSellorDeposit.Location.X, lblRentPrice.Location.Y);
                lblRentPrice.Visible = false;

                have.FindSale(privateNumber);
                lblRoomCount.Text = "Oda Sayısı : " + have.FindSale(privateNumber).RoomCount;
                lblFloorNumber.Text = "Kat Numarası : " + have.FindSale(privateNumber).FloorNumber + ".Kat";
                lblHouseSize.Text = "Evin Genişliği : " + have.FindSale(privateNumber).HouseSize+ " m²";
                lblBuildDate.Text = "Yapım Yılı : " + String.Format("{0:d/M/yyyy}", have.FindSale(privateNumber).BuildDate);
                lblAge.Text = "Evin Yaşı : " + have.FindSale(privateNumber).BuildingAge;
                lblHouseType.Text = "Evin Tipi : " + have.FindSale(privateNumber).HouseType;
                lblCity.Text = "Şehir : " + have.FindSale(privateNumber).Adress.City;
                lblDisc.Text = "İlçe : " + have.FindSale(privateNumber).Adress.District;
                lblStreet.Text = "Cadde/Sokak : " + have.FindSale(privateNumber).Adress.Street;
                lblDoorNumber.Text = "Kapı Numarası : " + have.FindSale(privateNumber).Adress.DoorNumber;
                lblSellorDeposit.Text = "Satış Fiyatı : " + have.FindSale(privateNumber).SalePrice.ToString("#,##0")+" TL";
                if (have.FindSale(privateNumber).IsArchive==true)
                {
                    lblArchive.Text += " Evet";
                    btnArchive.Text = "Arşiv Kaldır";
                }
                else
                {
                    lblArchive.Text += " Hayır";
                    btnArchive.Text = "Arşivle";
                }
               
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (listType==0)
            {
                if (have.FindRent(privateNumber).IsArchive==true)
                {
                    have.FindRent(privateNumber).IsArchive = false;
                    MessageBox.Show("Ev başarılı ile Arşivden Kaldırıldı....", "Arşivleme işlemi");
                }
                else
                {
                    have.FindRent(privateNumber).IsArchive = true;
                    MessageBox.Show("Ev başarılı ile arşivlendi....", "Arşivleme işlemi");
                }
              
            }
            else if (listType==1)
            {
                if (have.FindSale(privateNumber).IsArchive == true)
                {
                    have.FindSale(privateNumber).IsArchive = false;
                    MessageBox.Show("Ev başarılı ile Arşivden Kaldırıldı....", "Arşivleme işlemi");

                }
                else
                {
                    have.FindSale(privateNumber).IsArchive = true;
                    MessageBox.Show("Ev başarılı ile arşivlendi....", "Arşivleme işlemi");
                }

            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listType == 0)
            {
                Process.Start(have.FindRent(privateNumber).AppPath);
                
            }
            else if (listType == 1)
            {
                Process.Start(have.FindSale(privateNumber).AppPath);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //TODO:Kira Fiyatı Değişmeli
            this.Close();
        }
    }
}
