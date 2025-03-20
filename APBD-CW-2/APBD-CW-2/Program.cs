// See https://aka.ms/new-console-template for more information

using APBD_CW_2;

Kontener kontener=new KontenerL(40,40,20,5, true );
var kontenerMasaLadunku = kontener.MasaLadunku;
Console.WriteLine(kontenerMasaLadunku);
kontener.MasaLadunku = 5;
Console.WriteLine(kontener.NrSeryjny);
Kontener kontener1=new KontenerL(40,40,20,5, true);
Console.WriteLine(kontener1.NrSeryjny);