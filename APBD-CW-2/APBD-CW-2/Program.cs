// See https://aka.ms/new-console-template for more information

using APBD_CW_2;

Console.WriteLine("Kontener App");
Kontener kontener=new KontenerL(20,60,10,40,true);
Console.WriteLine(kontener.NrSeryjny);
kontener.Zaladuj(30);
Console.WriteLine(kontener.MasaLadunku);
 kontener.Zaladuj(7);
 Console.WriteLine(kontener.MasaLadunku);
 Kontener kontener2 = new KontenerG(20,60,10,50);
 Console.WriteLine(kontener2.NrSeryjny);
 kontener2.Zaladuj(40);
 kontener2.Zaladuj(7);
 Console.WriteLine(kontener2.MasaLadunku);
 kontener2.Oproznij();
 Console.WriteLine(kontener2.MasaLadunku);
 Kontener kontener3 = new KontenerC(20, 60, 10, 51, "Bananas", -10);
 kontener3.Zaladuj(40);
 kontener3.Zaladuj(7);
 Console.WriteLine(kontener3.ToString());
 Console.WriteLine("================================");
 Kontenerowiec kontenerowiec1 = new Kontenerowiec(40, 1000, 70, "Statek1");
 Kontenerowiec kontenerowiec2 = new Kontenerowiec(40, 1, 5, "Statek2");
 kontenerowiec1.Zaladuj(kontener);
 kontenerowiec1.Zaladuj(kontener2);
 kontenerowiec1.Zaladuj(kontener3);
 kontenerowiec1.ToString();
 kontenerowiec1.ShowList();
 Console.WriteLine("===============================");
kontenerowiec1.UsunKontener(kontener);
 Kontener kontener4 = new KontenerL(10,30,10,70,false);
 kontener4.Zaladuj(50);
 kontener4.Zaladuj(34);
 kontenerowiec1.ZamienKontener("KON-G-2", kontener4);
 kontenerowiec1.ShowList();
Console.WriteLine("============================");
 Kontener newkontener1 = new KontenerL(10,30,10,70,true);
 newkontener1.Zaladuj(30);
 Kontener newkontener2 = new KontenerG(10,60,10,50);
 newkontener2.Zaladuj(40);
 Kontener newkontener3 = new KontenerC(10,60, 10, 51, "Fish", 2);
 newkontener3.Zaladuj(40);

 try
 {
  kontenerowiec2.Zaladuj(newkontener2);
  kontenerowiec2.Zaladuj(newkontener3);
  kontenerowiec2.Zaladuj(newkontener1);
 }
 catch (OverfillException e)
 {
  Console.WriteLine(e);
  
 }
kontenerowiec2.ShowList();
kontenerowiec1.NaInnyStatek(kontenerowiec2,"KON-C-3");
Console.WriteLine("===============================");
Kontener konMax= new KontenerL(10,30,10,10000,false);
konMax.Zaladuj(5000);
kontenerowiec2.ShowList();
Console.WriteLine("===============================");
try
{
kontenerowiec2.Zaladuj(konMax);
}
catch (OverfillException e)
{
 Console.WriteLine(e);
 
}

Console.WriteLine("=============================");
Kontener nkon= new KontenerL(10,30,10,10000,true);
nkon.Zaladuj(100);
Kontener nkon2 = new KontenerG(10,60,10,50);
nkon.Zaladuj(10);
List<Kontener> konList = new List<Kontener>();
konList.Add(nkon);
konList.Add(nkon2);
kontenerowiec1.Zaladuj(konList);
kontenerowiec1.ShowList();
Console.WriteLine("==============================");
Kontener nkon3= new KontenerG(10,60,10,50);
nkon.Zaladuj(10);
Kontener nkon4= new KontenerC(10,60, 10, 51, "Fish", 2);
nkon.Zaladuj(10);

try
{
 kontenerowiec2.Zaladuj(nkon3);
 kontenerowiec2.Zaladuj(nkon4);

}
catch (Exception e)
{
 Console.WriteLine(e);

}
kontenerowiec2.ShowList();
Console.WriteLine("==================================");


 