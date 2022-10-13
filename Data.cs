using System;
using Utils;
using System.Collections.Generic;


namespace Models
{
    public  class Data
    {


        public List<Booking> BookingList {get;set;}

        public List<Restaurant> RestaurantList { get; set; }
        

         private static Data _instance = null;

         private Data()
        {

            BookingList = new List<Booking>();
            RestaurantList = new List<Restaurant>();
        }   

         public static Data GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Data();
            }
            return _instance;
        }

        public void InputRestaurant()
        {
           Console.WriteLine("Nhap so Nha Hang can them: ");
            int N = Utility.ReadInt();

            for(int i=0;i<N;i++)
            {
                Restaurant restaurant = new Restaurant();
                restaurant.Input();

                RestaurantList.Add(restaurant);
            }
        }

        public void DisplayRestaurant()
        {
             foreach(Restaurant restaurant in RestaurantList)
            {
                restaurant.Display();
            }
        }


        public void InputBooking()
        {
            if (RestaurantList.Count == 0) return;

            Booking booking = new Booking();
            booking.Input();

            BookingList.Add(booking);
        }


        public void SearchTableAvaiable()
        {
            Console.WriteLine("Nhap Ngay Dat Phong (yyyy-MM-dd HH:mm:ss): ");
            DateTime checkIn = Utility.ConvertStringToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap Ngay Tra Phong (yyyy-MM-dd HH:mm:ss): ");
            DateTime checkOut = Utility.ConvertStringToDateTime(Console.ReadLine());

            foreach(Restaurant restaurant in RestaurantList)
            {
                restaurant.SearchTableAvaiable(checkIn, checkOut);
            }
        }
    }
}