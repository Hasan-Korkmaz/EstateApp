using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Core.Adress
{
   public class Adress
    {


        string city, district, street, doorNumber;
        public string City { get => city; set => city = value; }
        public string District { get => district; set => district = value; }
        public string Street { get => street; set => street = value; }
        public string DoorNumber { get => doorNumber; set => doorNumber = value; }

        public override string ToString()
        {
            return City + " " + District + " " + Street + " " + DoorNumber;
        }
        public List<string> ListCity(string appPath)
        {
            List<string> outputText = new List<string>();
            List<string> City = new List<string>();
            Core.IO.InputOutput writerReader = new IO.InputOutput(appPath, "il_ilce.txt");
            writerReader.ReadAll(ref outputText);
            foreach (string item in outputText)
            {
                if (item.Contains("-"))
                {
                    City.Add(item.Split('-')[1]);
                }
            }

            return City;
        }
        public List<string> ListDisc(string appPath,string City)
        {
            bool findit = false;
            List<string> outputText = new List<string>();
            List<string> ListDisc = new List<string>();
            Core.IO.InputOutput writerReader = new IO.InputOutput(appPath, "il_ilce.txt");
            writerReader.ReadAll(ref outputText);
            foreach (string item in outputText)
            {
               
                if (item=='-'+ City)
                {
                    findit = true;
                    continue;
                }
                if (findit==true && !item.Contains('-'))
                {
                    ListDisc.Add(item);
                }
                else
                {
                    findit = false;
                }
            }

            return ListDisc;
        }
    }
}
