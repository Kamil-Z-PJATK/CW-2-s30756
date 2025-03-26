namespace APBD_CW_2;

public class ConsoleInterface
{
//===============Program nie jest dokończony===========================
    // public static void Main(string[] args)
    // {
    //     List<Kontenerowiec> kontenerowiecList = new List<Kontenerowiec>();
    //
    //     List<Kontener> kontenerList = new List<Kontener>();
    //
    //
    //     while (true)
    //     {
    //         Console.WriteLine("Lista kontenerowców: ");
    //         for (int i = 0; i < kontenerowiecList.Count; i++)
    //         {
    //             Console.WriteLine(kontenerowiecList[i].ToString());
    //             Console.WriteLine("Ładunek kontenerowca: ");
    //             kontenerowiecList[i].ShowList();
    //
    //         }
    //
    //         Console.WriteLine("\nLista kontenerów");
    //         foreach (var t in kontenerList)
    //         {
    //             Console.WriteLine(t.ToString());
    //         }
    //
    //         Console.WriteLine("\n1. Dodaj kontenerowiec");
    //
    //         if (kontenerowiecList.Count > 0)
    //         {
    //             Console.WriteLine("\n2. Usuń kontenerowiec");
    //             Console.WriteLine("\n3. Dodaj kontener");
    //             Console.WriteLine("\n4. Usuń kontenerowiec");
    //
    //         }
    //
    //         if (kontenerList.Count > 0)
    //         {
    //             Console.WriteLine("\n5. Zaladuj kontener");
    //             Console.WriteLine("\n6. Opróżnij kontener");
    //             Console.WriteLine("\n7. Dodaj kontener na statek");
    //             Console.WriteLine("\n8. Usun kontener ze statku");
    //             Console.WriteLine("\n9. Przenieś kontener z jednego statku na drugi");
    //             Console.WriteLine("\n10. Zaladuj wszystkie kontenery na statek");
    //         }
    //
    //         string wybor = Console.In.ReadLine();
    //         Operacje(wybor, kontenerowiecList, kontenerList);
    //
    //
    //         Console.Clear();
    //
    //
    //
    //     }
    //
    //
    //     static void Operacje(string wybor, List<Kontenerowiec> kontenerowiecList, List<Kontener> kontenerList)
    //     {
    //         switch (wybor)
    //         {
    //             case "1":
    //             {
    //                 Console.WriteLine("Podaj dane kontenerowca (prędkość, maxMasa, maxKon, nazwa)");
    //                 string kon = Console.In.ReadLine();
    //                 string[] kons = kon.Split(',');
    //                 if (kons.Length != 4)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //
    //                 }
    //                 else
    //                 {
    //                     Kontenerowiec kontenerowiec = new Kontenerowiec(double.Parse(kons[0]), double.Parse(kons[1]),
    //                         int.Parse(kons[2]), kons[3]);
    //                     kontenerowiecList.Add(kontenerowiec);
    //                 }
    //             }
    //                 break;
    //             case "2":
    //             {
    //                 Console.WriteLine("Podaj nazwe statku do usuniencia");
    //                 string nazwa = Console.In.ReadLine();
    //                 for (int i = 0; i < kontenerowiecList.Count(); i++)
    //                 {
    //                     if (kontenerowiecList[i].Nazwa == nazwa)
    //                     {
    //                         kontenerowiecList.RemoveAt(i);
    //                         break;
    //                     }
    //                 }
    //
    //                 Console.WriteLine("Niepoprawne dane");
    //                 Thread.Sleep(1000);
    //
    //             }
    //                 break;
    //
    //             case "3":
    //             {
    //                 Console.WriteLine("Podaj typ kontenera (L,C,G)");
    //                 string kon = Console.In.ReadLine();
    //
    //
    //                 if (kon.Equals("L"))
    //                 {
    //                     Console.WriteLine("Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa, czyBezpieczny)");
    //                     string ko = Console.In.ReadLine();
    //                     string[] kons = ko.Split(',');
    //                     if (kons.Count() != 5)
    //                     {
    //                         Console.WriteLine("Niepoprawne dane");
    //                         Thread.Sleep(1000);
    //
    //                     }
    //                     else
    //                     {
    //                         Kontener kontener = new KontenerL(double.Parse(kons[0]), double.Parse(kons[1]),
    //                             double.Parse(kons[2]), double.Parse(kons[3]), bool.Parse(kons[4]));
    //                         kontenerList.Add(kontener);
    //                     }
    //
    //                 }
    //                 else if (kon.Equals("C"))
    //                 {
    //                     Console.WriteLine(
    //                         "Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa,typ produktu,temperatura)");
    //                     string ko = Console.In.ReadLine();
    //                     string[] kons = ko.Split(',');
    //                     if (kons.Count() != 6)
    //                     {
    //                         Console.WriteLine("Niepoprawne dane");
    //                         Thread.Sleep(1000);
    //
    //                     }
    //                     else
    //                     {
    //                         Kontener kontener = new KontenerC(double.Parse(kons[0]), double.Parse(kons[1]),
    //                             double.Parse(kons[2]), double.Parse(kons[3]), kons[4], double.Parse(kons[5]));
    //                         kontenerList.Add(kontener);
    //                     }
    //                 }
    //                 else if (kon.Equals("G"))
    //                 {
    //                     Console.WriteLine("Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa)");
    //                     string ko = Console.In.ReadLine();
    //                     string[] kons = ko.Split(',');
    //                     if (kons.Count() != 4)
    //                     {
    //                         Console.WriteLine("Niepoprawne dane");
    //                         Thread.Sleep(1000);
    //
    //                     }
    //                     else
    //                     {
    //                         Kontener kontener = new KontenerG(double.Parse(kons[0]), double.Parse(kons[1]),
    //                             double.Parse(kons[2]), double.Parse(kons[3]));
    //                         kontenerList.Add(kontener);
    //                     }
    //                 }
    //             }
    //                 break;
    //
    //             case "4":
    //             {
    //                 Console.WriteLine("Podaj nr seryjny kontenera do usunięcia");
    //                 string nrSer = Console.In.ReadLine();
    //
    //                 int nr = ZnajdzKontener(nrSer, kontenerList);
    //
    //                 if (nr == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //
    //                 }
    //                 else
    //                 {
    //                     kontenerList.RemoveAt(nr);
    //                 }
    //
    //             }
    //                 break;
    //             case "5":
    //             {
    //                 Console.WriteLine("Podaj nr seryjny kontenera który chcesz załadować");
    //                 string nrSer = Console.In.ReadLine();
    //
    //                 int nr = ZnajdzKontener(nrSer, kontenerList);
    //
    //                 if (nr == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine("Podaj masę ładynku");
    //                     string masa = Console.In.ReadLine();
    //                     try
    //                     {
    //                         kontenerList[nr].Zaladuj(double.Parse(masa));
    //                     }
    //                     catch (OverfillException e)
    //                     {
    //                         Console.WriteLine(e);
    //                         Thread.Sleep(1000);
    //
    //                     }
    //                 }
    //             }
    //                 break;
    //             case "6":
    //             {
    //                 Console.WriteLine("Podaj nr seryjny kontenera do opróżnienia");
    //                 string nrSer = Console.In.ReadLine();
    //
    //                 int nr = ZnajdzKontener(nrSer, kontenerList);
    //
    //                 if (nr == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //                 else
    //                 {
    //                     kontenerList[nr].Oproznij();
    //
    //                 }
    //
    //             }
    //                 break;
    //
    //             case "7":
    //             {
    //                 Console.WriteLine(
    //                     "Podaj nr Seryjny kontenera oraz nazwę statku na który chcesz załadować kontener");
    //                 string str = Console.In.ReadLine();
    //                 string[] kons = str.Split(',');
    //                 if (kons.Count() != 2)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //
    //                 int stat = ZnajdzStatek(kons[1], kontenerowiecList);
    //                 int kon = ZnajdzKontener(kons[0], kontenerList);
    //                 if (stat == -1 || kon == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //                 else
    //                 {
    //                     kontenerowiecList[stat].Zaladuj(kontenerList[kon]);
    //                 }
    //                 //  kontenerowiecList[kont].Zaladuj(kontenerList[ZnajdzKontener(kons[0],kontenerList)]);
    //
    //             }
    //                 break;
    //
    //             case "8":
    //             {
    //                 Console.WriteLine(
    //                     "Podaj numer seryjny kontenera który ma zostać usunięty i nazwę statku z którego usuwamy kontener");
    //                 string str = Console.In.ReadLine();
    //                 string[] kons = str.Split(',');
    //                 if (kons.Count() != 2)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //
    //                 int stat = ZnajdzStatek(kons[1], kontenerowiecList);
    //                 int kon = ZnajdzKontener(kons[0], kontenerowiecList[stat].KontenerList);
    //                 if (stat == -1 || kon == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //
    //                 kontenerowiecList[stat].UsunKontener(kon);
    //
    //             }
    //                 break;
    //
    //             case "9":
    //             {
    //                 Console.WriteLine(
    //                     "Podaj nazwę statku z którego chcesz przenieść kontener, nr seryjny kontenera, nazwę statku na który przenosimy");
    //                 string str = Console.In.ReadLine();
    //                 string[] kons = str.Split(',');
    //                 if (kons.Length != 3)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //
    //                 int st1 = ZnajdzStatek(kons[0], kontenerowiecList);
    //                 int st2 = ZnajdzStatek(kons[2], kontenerowiecList);
    //                 //  int kon = ZnajdzKontener(kons[2], kontenerowiecList[st1].KontenerList);
    //                 if (st1 == -1 || st2 == -1)
    //                 {
    //                     Console.WriteLine("Niepoprawne dane");
    //                     Thread.Sleep(1000);
    //                 }
    //
    //                 kontenerowiecList[st1].NaInnyStatek(kontenerowiecList[st2], kons[1]);
    //
    //             }
    //                 break;
    //             case "10":
    //             {
    //                 Console.WriteLine("Podaj nezwę statku na który chcesz ");
    //             }
    //                 break;
    //         }
    //
    //
    //     }
    // }
    //
    //
    // static int ZnajdzKontener(string nrSer, List<Kontener> kontenerList)
    //        {
    //            for (int i = 0; i < kontenerList.Count; i++)
    //            {
    //                if (kontenerList[i].NrSeryjny == nrSer)
    //                {
    //                    return i;
    //                }
    //            }
    //            return -1;
    //        }
    //        
    //        static int ZnajdzStatek(string nazwa, List<Kontenerowiec> kontenerList)
    //        {
    //            for (int i = 0; i < kontenerList.Count; i++)
    //            {
    //                if (kontenerList[i].Nazwa ==nazwa)
    //                {
    //                    return i;
    //                }
    //            }
    //            return -1;
    //
    //  }
}