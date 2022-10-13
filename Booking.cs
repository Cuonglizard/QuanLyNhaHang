using System;
using Utils;


namespace Models
{
    public class Booking
    {
        public string RestaurantNo {get;set;}

        public string  TableNo {get;set;}

        public DateTime CheckIn {get;set;}

        public DateTime CheckOut {get;set;}


        public  void Input()
        {
            Data dataMgr = Data.GetInstance();
            bool isFind = false;
            Restaurant currentRestaurant= null;

            Console.WriteLine("Nhap Ma Nha hang: ");
            while(true)
            {
                RestaurantNo = Console.ReadLine();
                isFind = false;
                foreach(Restaurant restaurant in dataMgr.RestaurantList)
                {
                    if(restaurant.RestaurantNo == RestaurantNo)
                    {
                        currentRestaurant = restaurant;
                        isFind = true;
                        break;
                    }
                }
                if(isFind)
                {
                    break;
                } else
                {
                    Console.WriteLine("Nhap lai!!!");
                }
            }
            if (currentRestaurant.TableList.Count == 0) return;

            Console.WriteLine("Nhap Ma Ban: ");
            while (true)
            {
                TableNo = Console.ReadLine();
                isFind = false;
                foreach (Table table in currentRestaurant.TableList)
                {
                    if (table.TableNo == TableNo)
                    {
                        isFind = true;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai!!!");
                }
            }
            Console.WriteLine("Nhap Ngay gio Dat Ban (yyyy-MM-dd HH:mm:ss): ");
            CheckIn = Utility.ConvertStringToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap Ngay gio Tra Ban (yyyy-MM-dd HH:mm:ss): ");
            CheckOut = Utility.ConvertStringToDateTime(Console.ReadLine());
        }


        public void Display()
        {
            Console.WriteLine("Ma Nha Hang: {0}, Ma ban: {1} " +
                "Ngay Dat Ban: {2}, Gio Tra Ban: {3}", RestaurantNo, TableNo
                , Utility.ConvertDateTimeToString(CheckIn),
                Utility.ConvertDateTimeToString(CheckOut));
        }
    }
}