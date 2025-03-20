// See https://aka.ms/new-console-template for more information

using APBD_CW_2;

Console.WriteLine("Kontener App");
Kontener kontener=new KontenerL(40,60,10,40,true);
Console.WriteLine(kontener.NrSeryjny);
kontener.Zaladuj(30);
Console.WriteLine(kontener.MasaLadunku);
 kontener.Zaladuj(7);
 Console.WriteLine(kontener.MasaLadunku);