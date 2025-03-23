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
 Kontener kontener3 = new KontenerC(20, 60, 10, 50, "Bananas", -10);
kontener3.Zaladuj(40,"Bananas");
 Console.WriteLine(kontener3.ToString());

 