  // ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
using System.ComponentModel;

DavomEt:
System.Console.WriteLine("Welcome to my project!");
System.Console.WriteLine("===========Asosiy=========,===========Chizish=========");
 System.Console.Write("tanlang: ");
string Select = Console.ReadLine();

if(Select == "1")
{
    System.Console.WriteLine("What do you need?");
    System.Console.WriteLine("Kubning hajmini: ======= To'rtburchak primetri: ======= Uchburchakning primetri");
    string tanlang = Console.ReadLine();

    if(tanlang == "1")
    {
      System.Console.WriteLine("Kubning tomonlarini kiriting:");
      System.Console.Write("Kubning eni: ");
      int eni = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Kubning bo'yi: ");
      int buyi = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Kubning balandligi: ");
      int balandligi = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine($"Kubning hajmi: {eni * buyi * balandligi}");
    }
   else if(tanlang == "2")
    {
        System.Console.WriteLine("Turburchakning tomonlarini kiriting: ");
        System.Console.Write("A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Primetr: {(A + B) * 2}");
    }
    if(tanlang == "3")
    {
        System.Console.WriteLine("Uchburchakning tomonlarini kiriting:");
        System.Console.Write("A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("C: ");
        int C = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Uchburchakning primetri: {A + B + C}");
    }
}

if(Select == "2")
{
    System.Console.WriteLine("What do you want to draw?");
    System.Console.WriteLine("Turtburchak rasmi:=========Kvadrat rasmi:==========Uchburchak rasmi");
    System.Console.Write("Nima kerak: ");
    string What = Console.ReadLine();

    if(What == "1")
    {
        System.Console.WriteLine("**********\n*        *\n*        *\n*        *\n*        *\n**********\n");
    }
    if(What == "2")
    {
         Console.WriteLine("**********\n*        *\n*        *\n*        *\n**********\n");
    }
    if(What == "3")
    {
         Console.WriteLine("       *\n     *  *\n    *    *\n   *      *\n  *        *\n *          *\n**************");
    }
}
System.Console.WriteLine("Davom etasizmi?");
string Tanlang = Console.ReadLine();
if(Tanlang == "Yes")
{
    goto DavomEt;
}
else if(Tanlang == "No")
{
    System.Console.WriteLine("Siz bilan xayrlashamiz!");
}
