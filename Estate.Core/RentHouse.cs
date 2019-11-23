using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Core
{
    public class RentHouse : House
    {
        public RentHouse() { }
        public RentHouse(int roomCount):base(roomCount)
        {
            FiyatHesapla();
        }
        public RentHouse(int roomCount, int floorNumber, double houseSize, House.Type houseType, DateTime buildDate, bool isActive, bool isDelete, bool isArchive,double rentDeposit, Adress.Adress adress)
            :base(roomCount, floorNumber, houseSize, houseType, buildDate, isActive, isDelete, isArchive, adress)
        {
          
            this.RentDeposit = rentDeposit;
            
            FiyatHesapla();
        }
        protected double rentDeposit, rentPrice;
        public double RentDeposit { get => rentDeposit; set => rentDeposit = value; }
        public double RentPrice { get => rentPrice; set => rentPrice = value; }
        public override string HouseDetailsString()
        {
            string status;
            if (IsActive == true)
            {
                status = "Boş";
            }
            else
            {
                status = "Dolu";

            }
            return string.Format("Yapı Kodu : {0}\nYapı Tipi : {1} Yapım Yılı : {2:yyyy}\nBina Yaşı : {3}\nOda Sayısı : {4}\nKat Numarası : {5}\nBüyüklüğü : {6} m²\nDurumu : {7}\nKira Ücreti : {8:C}\nDepozitosu : {9:C}\nAdresi : {10}",
                PrivateNumber, HouseType, BuildDate, BuildingAge, RoomCount, FloorNumber, HouseSize, status, RentPrice, RentDeposit, Adress);
        }
        private double FiyatHesapla()
        {
            Core.IO.InputOutput writerReader = new IO.InputOutput(Logger.Logger.getInstance().AppPath, "room_cost.txt");
            string roomcost = "";

            if (writerReader.Read(ref roomcost) == -1)
            {
                RentPrice = 200 * RoomCount;
            }
            else
            {
                RentPrice = (Convert.ToInt32(roomcost) * RoomCount);
            }
            return RentPrice;
        }



    }
}
