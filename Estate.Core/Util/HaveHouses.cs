using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Core.Util
{
    public class HaveHouses
    {

        private static HaveHouses myHouses;
        List<RentHouse> myRentHouseList;
        List<SaleHouse> mySaleHouseList;
        string appPath;
        public string AppPath
        {
            get => appPath; set
            {
                appPath = value;
                myRentHouseList = new List<RentHouse>();
                mySaleHouseList = new List<SaleHouse>();
                Core.IO.InputOutput writerReaderForRent = new IO.InputOutput(AppPath, "rentHouse.txt");
                Core.IO.InputOutput writerReaderForSale = new IO.InputOutput(AppPath, "saleHouse.txt");
                RentHouse rh;
                SaleHouse sH;
                Adress.Adress newAdress;
                List<string> stringToText = new List<string>();
                writerReaderForRent.ReadAll(ref stringToText);

                foreach (string item in stringToText)
                {

                    rh = new RentHouse(int.Parse(item.Split('|')[5]));
                    newAdress = new Adress.Adress();
                    rh.PrivateNumber = item.Split('|')[0].Remove(0, 1);
                    rh.BuildDate = DateTime.Parse(item.Split('|')[1]);
                    rh.FloorNumber = int.Parse(item.Split('|')[2]);
                    rh.HouseType = (Core.House.Type)Enum.Parse(typeof(Core.House.Type), item.Split('|')[3]);
                    rh.HouseSize = double.Parse(item.Split('|')[4]);
                    rh.AppPath = appPath + @"\" + rh.PrivateNumber;


                    rh.RentDeposit = double.Parse(item.Split('|')[6]);
                    rh.IsActive = bool.Parse(item.Split('|')[7]);
                    rh.IsArchive = bool.Parse(item.Split('|')[8]);
                    rh.IsDelete = bool.Parse(item.Split('|')[9]);

                    newAdress.City = item.Split('|')[10].Split(',')[0];
                    newAdress.District = item.Split('|')[10].Split(',')[1];
                    newAdress.Street = item.Split('|')[10].Split(',')[2];
                    newAdress.DoorNumber = item.Split('|')[10].Split(',')[3];
                    rh.Adress = newAdress;

                    myRentHouseList.Add(rh);
                }
                stringToText = new List<string>();
                writerReaderForSale.ReadAll(ref stringToText);
                foreach (var item in stringToText)
                {

                    sH = new SaleHouse();
                    newAdress = new Adress.Adress();
                    sH.PrivateNumber = item.Split('|')[0].Remove(0, 1);
                    sH.BuildDate = DateTime.Parse(item.Split('|')[1]);
                    sH.FloorNumber = int.Parse(item.Split('|')[2]);
                    sH.HouseType = (Core.House.Type)Enum.Parse(typeof(Core.House.Type), item.Split('|')[3]);
                    sH.HouseSize = double.Parse(item.Split('|')[4]);
                    sH.RoomCount = int.Parse(item.Split('|')[5]);
                    sH.AppPath = appPath + @"\" + sH.PrivateNumber;

                    sH.SalePrice = double.Parse(item.Split('|')[6]);
                    sH.IsActive = bool.Parse(item.Split('|')[7]);
                    sH.IsArchive = bool.Parse(item.Split('|')[8]);
                    sH.IsDelete = bool.Parse(item.Split('|')[9]);

                    newAdress.City = item.Split('|')[10].Split(',')[0];
                    newAdress.District = item.Split('|')[10].Split(',')[1];
                    newAdress.Street = item.Split('|')[10].Split(',')[2];
                    newAdress.DoorNumber = item.Split('|')[10].Split(',')[3];
                    sH.Adress = newAdress;
                    mySaleHouseList.Add(sH);
                }
            }
        }

        HaveHouses()
        {

        }

        ~HaveHouses()
        {
            IO.InputOutput WriterReaderforRent = new IO.InputOutput(AppPath, "rentHouse.txt");
            IO.InputOutput WriterReaderforSale = new IO.InputOutput(AppPath, "saleHouse.txt");
            List<string> myListisStringFormat = new List<string>();
            foreach (var item in myRentHouseList)
            {

                myListisStringFormat.Add("*" + item.PrivateNumber + '|' + item.BuildDate + '|' + item.FloorNumber + '|' + item.HouseType.ToString() + '|' + item.HouseSize + '|' + item.RoomCount + '|' + ((RentHouse)item).RentDeposit + '|' + item.IsActive + '|'+item.IsArchive+'|'+item.IsDelete +'|'+ item.Adress.City + ',' + item.Adress.District + ',' + item.Adress.Street + ',' + item.Adress.DoorNumber);

            }
            WriterReaderforRent.ReWrite(myListisStringFormat);
            myListisStringFormat = new List<string>();
            foreach (var item in mySaleHouseList)
            {
                myListisStringFormat.Add("+" + item.PrivateNumber + '|' + item.BuildDate + '|' + item.FloorNumber + '|' + item.HouseType.ToString() + '|' + item.HouseSize + '|' + item.RoomCount + '|' + ((SaleHouse)item).SalePrice + '|' + item.IsActive + '|' + item.IsArchive + '|' + item.IsDelete + '|' + item.Adress.City + ',' + item.Adress.District + ',' + item.Adress.Street + ',' + item.Adress.DoorNumber);

            }
            WriterReaderforSale.ReWrite(myListisStringFormat);

        }
        public static HaveHouses getInstance()
        {
            if (myHouses == null)
            {
                myHouses = new HaveHouses();
            }
            return myHouses;
        }
        public List<RentHouse> RentHouseList()
        {
            return myRentHouseList;
        }
        public List<SaleHouse> SaleHouseList()
        {
            return mySaleHouseList;
        }
        public int AddList(House house)
        {
            if (house.GetType() == typeof(SaleHouse))
            {
                mySaleHouseList.Add ( (SaleHouse)house);
                return 1;


            }
            else if (house.GetType() == typeof(RentHouse))
            {
                myRentHouseList.Add((Core.RentHouse)house);
                return 1;

            }
            else
            {
                return -1;
            }
            
        }
        
        public int RemoveRentHouse(string privateNumber)
        {
            FindRent(privateNumber).IsDelete = true;
            return 1;
        }
        public int RemoveSaleHouse(string privateNumber)
        {
            FindSale(privateNumber).IsDelete = true;
            return 1;
        }
        public RentHouse FindRent(string privateNumber)
        {
          return  myRentHouseList.Where(x => x.PrivateNumber == privateNumber).FirstOrDefault();
        }
        public SaleHouse FindSale(string privateNumber)
        {
            return mySaleHouseList.Where(x => x.PrivateNumber == privateNumber).FirstOrDefault();
        }
        public string Edit(House house)
        {
            SaleHouse slTemp;
            RentHouse rtTemp;
            if (house.GetType()==typeof(SaleHouse))
            {
                slTemp =(SaleHouse) house;
                return slTemp.GetType().ToString();


            }
            else if (house.GetType()==typeof(RentHouse))
            {
                rtTemp = (RentHouse)house;
               return rtTemp.RentDeposit.ToString();
            }
            else
            {
                return "";
            }
        }
        




    }
}
