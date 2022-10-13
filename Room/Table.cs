using  System;
using Utils;

namespace Models
{
    public class Table : ITable
    {
        public string Name { get; set; }
        public string TableNo { get; set; }
        public int Floor { get; set; }
        public int MaxNum { get; set; }

        public void Input()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Nhap ten Phong: ");
            Name=Console.ReadLine();
            Console.WriteLine("Nhap ma so ban: ");
            TableNo = Console.ReadLine();
            Console.WriteLine("Nhap tang: ");
            Floor = Utility.ReadInt();
            Console.WriteLine("Nhap so nguoi toi da");
            MaxNum=Utility.ReadInt();
        }

        public void Display()
        {
            Console.WriteLine("Ten phong: {0}, ma phong: {1}, tang: {2}, " +
                "so nguoi toi da: {3}", Name, TableNo, Floor, MaxNum);
        }
    }

    
}