using   System;
using Utils;

namespace Models
{
    class program
    {
        static void Main(string[]args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose= Utility.ReadInt();

                switch (choose)
                {
                    case 1:
                            Data.GetInstance().InputBooking();
                            break;
                    case 2:
                            Data.GetInstance().DisplayRestaurant();
                            break;
                    case 3: 
                            Data.GetInstance().InputBooking();
                            break;
                    case 4:
                             Data.GetInstance().SearchTableAvaiable();
                            break;
                    case 5:
                            Console.WriteLine("Thoat");
                            break;
                    default:
                            Console.WriteLine("Nhap Sai!!");
                            break;
                }
            }while(choose !=5);
        }


        static void ShowMenu()
        {
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4.Danh sach ban con trong");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Chon: ");
        }
    }
}