using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Core
{
    public class SaleHouse : House
    {
        double salePrice;
        public SaleHouse() { }
        public SaleHouse( int roomCount, int floorNumber,double houseSize, House.Type houseType, DateTime buildDate,bool isActive,bool isDelete,bool isArchive,double salePrice,Adress.Adress adress) 
            :base(roomCount,floorNumber,houseSize,houseType,buildDate,isActive,isDelete,isArchive,adress)
        {
            
            this.SalePrice = salePrice;
        }

        public double SalePrice { get => salePrice; set => salePrice = value; }

    }

}
