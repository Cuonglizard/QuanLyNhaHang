using System;
using Utils;


namespace Models
{
    public class Restaurant
    {
        public String Name{get;set;}
        public string RestaurantNo { get; set; }
        public string Address { get; set; }
        public List<Table> TableList { get; set; }

        public Restaurant()
        {
            TableList= new List<Table>();
        }

       public void Input()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Nhap Ten Nha hang: ");
            Name= Console.ReadLine();

            Console.WriteLine("Nhap ma Nha Hang");
            RestaurantNo=Console.ReadLine();

            Console.WriteLine("Nhap so ban cua nha hang");
            int N=Utility.ReadInt();

            for(int i=0;i<N;i++)
             {
                Table table = new Table();
                table.Input();

                TableList.Add(table);
            }
        }


         public void Display()
        {
            Console.WriteLine("Ten Nha Hang: {0}, Ma Nha Hang: {1}, Dia chi: {2}",
                Name, RestaurantNo, Address);

            foreach(Table table in TableList)
            {
                table.Display();
            }
        }


        // 
        public void SearchTableAvaiable(DateTime checkIn, DateTime checkOut)
        {
            List<string> unavailtableRoomList = GetTableUnavaialbe(checkIn, checkOut);

            Console.WriteLine("=== Danh sach ban con trong cua nha hang: {0}, Ma nha Hang: {1}", Name, RestaurantNo);
            foreach(Table table in TableList)
            {
                if(!unavailtableRoomList.Contains(table.TableNo))
                {
                    table.Display();
                }
            }
        }


        List<string> GetTableUnavaialbe(DateTime checkIn, DateTime checkOut)
        {
            List<string> tableList = new List<string>();
            List<Booking> bookingList = Data.GetInstance().BookingList;     ///

            foreach(Booking booking in bookingList)
            {
                if(booking.RestaurantNo == RestaurantNo)
                {
                    if((booking.CheckIn <= checkIn && booking.CheckOut >= checkIn) ||
                        (booking.CheckIn <= checkOut && booking.CheckOut >= checkOut) ||
                        (booking.CheckIn > checkIn && booking.CheckOut < checkOut))
                    {
                        if(!tableList.Contains(booking.TableNo))
                        {
                            tableList.Add(booking.TableNo);
                        }
                    }
                }
            }

            return tableList;
        }

         public void BillOfTable()
    {
        
    }
    }
}