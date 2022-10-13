// using System;
// using Utils;
// using System.Collections.Generic;  
// namespace Models
// {
//     class SanPham
//     {  
//         Dictionary<string, double> openWith = new Dictionary<string, double>();

//         openWith.Add("Comthapcam",3);   
//         openWith.Add("ComRang",2.5);
//         openWith.Add("SoupCua",5);
//         openWith.Add("VyCamap",30);
//         openWith.Add("RuouVangPhap",50);

//         List<string> DanhsachDoMonan = new List<string>();

//         public void Input()
//         {   
//             double Tong=0;
//             int choose;

//             do
//             {
//                 Display();
//                 choose= Utility.ReadInt();

//                 switch(choose)
//                 {
//                     case 1: 
//                              Tong=Tong+3;
//                              DanhsachDoMonan.Add("Com_Thap_cam");
//                              break;
//                     case 2:
//                              Tong=Tong+3;
//                              DanhsachDoMonan.Add("Com_Rang");
//                              break;
//                     case 3:
//                             Tong=Tong+3;
//                             DanhsachDoMonan.Add("Soup_Cua");
//                             break;
//                     case 4:
//                             Tong=Tong+3;
//                             DanhsachDoMonan.Add("Vy_Ca_map");
//                              break;
//                     case 5:
//                             Tong=Tong+3;
//                             DanhsachDoMonan.Add("Ruou_Vang_Phap");
//                              break;
//                     case 6:
//                     Console.WriteLine("Thoat!!!");
//                         break;
//                      default:
//                             Console.WriteLine("Nhap Sai!!");
//                             break;
//                 }

//             }while(choose!=6);
//         }

//         public void Display()
//         {               
//                         Console.WriteLine("             Bang_Gia             ")
//                         Console.WriteLine("==================================");
//                         Console.WriteLine("Com_Thap_cam--------------------3$");
//                         Console.WriteLine("Com_Rang----------------------2,5$");
//                         Console.WriteLine("Soup_Cua------------------------5$");
//                         Console.WriteLine("Vy_Ca_map----------------------30$");
//                         Console.WriteLine("Ruou_Vang_Phap-----------------50$");
//         }
//     }
    
// }