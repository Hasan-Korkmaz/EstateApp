using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Estate.Core
{
    public class House
    {
        public House(int roomCount, int floorNumber, double houseSize, House.Type houseType, DateTime buildDate, bool isActive, bool isDelete, bool isArchive, Adress.Adress adress)
        {
            PrivateNumber = Guid.NewGuid().ToString();
            logger = Logger.Logger.getInstance();
            IO.InputOutput io = new IO.InputOutput(logger.AppPath, privateNumber);
            AppPath = logger.AppPath + @"\" + privateNumber;
            io.CreateDirectory();
            this.RoomCount = roomCount;
            this.FloorNumber = floorNumber;
            this.HouseSize = houseSize;
            this.HouseType = houseType;
            this.BuildDate = buildDate;
            this.IsActive = isActive;
            this.IsDelete = isDelete;
            this.IsArchive = isArchive;
            this.Adress = adress;
        }
        public House()
        {
            logger = Logger.Logger.getInstance();
         

        }
        public House(int roomCount)
        {
            logger = Logger.Logger.getInstance();
            this.roomCount = roomCount;
            IO.InputOutput io = new IO.InputOutput(logger.AppPath , privateNumber);
            AppPath = logger.AppPath + @"\" + privateNumber;
            io.CreateDirectory();


        }

        
        


        #region Variable
        public enum Type
        {
            Daire,
            Bahçeli,
            Dubleks,
            Müstakil,
        }
        private int roomCount, floorNumber;
        string privateNumber;
        private double houseSize;
        private House.Type houseType;
        private DateTime buildDate;
        private bool isActive, isDelete, isArchive;
        private string appPath;
        Adress.Adress adress;
        readonly Logger.Logger logger;
        #endregion

        #region Properties

        public double BuildingAge
        {
            get
            {
                TimeSpan age = DateTime.Now - BuildDate;
                return (age.Days / 365);
            }
        }
        public int RoomCount
        {
            get
            {
                return roomCount;
            }
            set
            {
                int data = value;
                logger.NewLog("RoomCount Logger Value : " + data + "| DateTime : " + DateTime.Now);
                if (data < 0)
                {
                    data = 0;
                    roomCount = data;
                }
                else
                {
                    roomCount = data;
                }
            }
        }
        public Type HouseType { get => houseType; set => houseType = value; }
        public DateTime BuildDate { get => buildDate; set => buildDate = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public double HouseSize { get => houseSize; set => houseSize = value; }
        public string PrivateNumber { get => privateNumber; set => privateNumber = value; }
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public Adress.Adress Adress { get => adress; set => adress = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
        public bool IsArchive { get => isArchive; set => isArchive = value; }
        public string AppPath { get => appPath; set => appPath = value; }
        #endregion

        public virtual string HouseDetailsString()
        {
            string status;
            if (isActive == true)
            {
                status = "Boş";
            }
            else
            {
                status = "Dolu";

            }
            return string.Format("{0} Numaralı Yapı.\nYapı Tipi : {1} Yapım Yılı : {2:yyyy}\n Bina Yaşı : {3}\nOda Sayısı : {4}\n Kat Numarası : {5}\nBüyüklüğü : {6} m²\n Durumu : {7}\nAdresi : {8}",
                PrivateNumber, HouseType, BuildDate, BuildingAge, RoomCount, FloorNumber, HouseSize, status, Adress.ToString());
        }
    }
}
