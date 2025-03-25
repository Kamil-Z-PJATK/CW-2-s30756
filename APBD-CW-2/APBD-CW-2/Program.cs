// See https://aka.ms/new-console-template for more information

using APBD_CW_2;

// Console.WriteLine("Kontener App");
// Kontener kontener=new KontenerL(20,60,10,40,true);
// Console.WriteLine(kontener.NrSeryjny);
// kontener.Zaladuj(30);
// Console.WriteLine(kontener.MasaLadunku);
//  kontener.Zaladuj(7);
//  Console.WriteLine(kontener.MasaLadunku);
//  Kontener kontener2 = new KontenerG(20,60,10,50);
//  Console.WriteLine(kontener2.NrSeryjny);
//  kontener2.Zaladuj(40);
//  kontener2.Zaladuj(7);
//  Console.WriteLine(kontener2.MasaLadunku);
//  kontener2.Oproznij();
//  Console.WriteLine(kontener2.MasaLadunku);
//  Kontener kontener3 = new KontenerC(20, 60, 10, 50, "Bananas", -10);
// kontener3.Zaladuj(40,"Bananas");
//  Console.WriteLine(kontener3.ToString());

List<Kontenerowiec> kontenerowiecList = new List<Kontenerowiec>();

List<Kontener> kontenerList = new List<Kontener>();


while (true)
{
    Console.WriteLine("Lista kontenerowców: ");
    for (int i = 0; i < kontenerowiecList.Count; i++)
    {
        Console.WriteLine(kontenerowiecList[i].ToString());
    }
    Console.WriteLine("\nLista kontenerów");
    foreach (var t in kontenerList)
    {
        Console.WriteLine(t.ToString());
    }
    
    Console.WriteLine("\n1. Dodaj kontenerowiec");
    
    if (kontenerowiecList.Count > 0)
    {
        Console.WriteLine("\n2. Usuń kontenerowiec");
        Console.WriteLine("\n3. Dodaj kontener");
        Console.WriteLine("\n4. Usuń kontenerowiec");
        
    }

    if (kontenerList.Count > 0)
    {
        Console.WriteLine("\n5. Zaladuj kontener");
        Console.WriteLine("\n6. Opróżnij kontener");
    }
    
    string wybor = Console.In.ReadLine();
    Operacje(wybor,kontenerowiecList,kontenerList);

    
    Console.Clear();

    

}


static void Operacje(string wybor, List<Kontenerowiec> kontenerowiecList, List<Kontener> kontenerList)
{
        switch (wybor)
        {
            case "1":
            {
                Console.WriteLine("Podaj dane kontenerowca (prędkość, maxMasa, maxKon, nazwa)");
                string kon = Console.In.ReadLine();
                string[] kons = kon.Split(',');
                if (kons.Length!=4)
                {
                    Console.WriteLine("Niepoprawne dane");
                }
                else
                {
                    Kontenerowiec kontenerowiec = new Kontenerowiec(double.Parse(kons[0]), double.Parse(kons[1]), int.Parse(kons[2]), kons[3]);
                    kontenerowiecList.Add(kontenerowiec);
                }
            } break;
            case "2":
            {
                Console.WriteLine("Podaj nazwe statku do usuniencia");
                string nazwa = Console.In.ReadLine();
                for (int i = 0; i < kontenerowiecList.Count(); i++)
                {
                    if (kontenerowiecList[i].Nazwa==nazwa)
                    {
                        kontenerowiecList.RemoveAt(i);
                        break;
                    }
                }
            }break;
    
            case "3":
            {
                Console.WriteLine("Podaj typ kontenera (L,C,G)");
                string kon = Console.In.ReadLine();
                
    
                if (kon.Equals("L"))
                {
                    Console.WriteLine("Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa, czyBezpieczny)");
                    string ko = Console.In.ReadLine();
                    string[] kons = ko.Split(',');
                    if (kons.Count() != 5)
                    {
                        Console.WriteLine("Niepoprawne dane");
                    }
                    else
                    {
                         Kontener kontener=new KontenerL(double.Parse(kons[0]), double.Parse(kons[1]), double.Parse(kons[2]), double.Parse(kons[3]),bool.Parse(kons[4]));
                         kontenerList.Add(kontener);
                    }
                   
                }
                else if (kon.Equals("C"))
                {
                    Console.WriteLine("Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa,typ produktu,temperatura)");
                    string ko = Console.In.ReadLine();
                    string[] kons = ko.Split(',');
                    if (kons.Count() != 6)
                    {
                     Console.WriteLine("Niepoprawne dane");
                    }
                    else
                    {
                        Kontener kontener=new KontenerC(double.Parse(kons[0]), double.Parse(kons[1]), double.Parse(kons[2]), double.Parse(kons[3]),kons[4], double.Parse(kons[5]));
                        kontenerList.Add(kontener);
                    }
                }
                else if (kon.Equals("G"))
                {
                    Console.WriteLine("Podaj dane kontenera (masa, wysokosc,głębokość,maxMasa)");
                    string ko = Console.In.ReadLine();
                    string[] kons = ko.Split(',');
                    if (kons.Count() != 4)
                    {
                        Console.WriteLine("Niepoprawne dane");
                    }
                    else
                    {
                        Kontener kontener=new KontenerG(double.Parse(kons[0]), double.Parse(kons[1]), double.Parse(kons[2]), double.Parse(kons[3]));
                        kontenerList.Add(kontener);
                    }
                }
            }break;
    
            case "4":
            {
                Console.WriteLine("Podaj nr seryjny kontenera do usunięcia");
                string nrSer = Console.In.ReadLine();
                
                int nr=ZnajdzKontener(nrSer,kontenerList);

                if (nr== -1)
                {
                    Console.WriteLine("Niepoprawne dane");
                }
                else
                {
                     kontenerList.RemoveAt(nr);
                }
              
            }break;
            case "5":
            {
                Console.WriteLine("Podaj nr seryjny kontenera który chcesz załadować");
                string nrSer = Console.In.ReadLine();
                
                int nr=ZnajdzKontener(nrSer,kontenerList);

                if (nr== -1)
                {
                    Console.WriteLine("Niepoprawne dane");
                }
                else
                {
                    Console.WriteLine("Podaj masę ładynku");
                    string masa = Console.In.ReadLine();
                    try
                    {
                        kontenerList[nr].Zaladuj(double.Parse(masa));
                    }
                    catch (OverfillException e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }break;
            case "6":
            {
                Console.WriteLine("Podaj nr seryjny kontenera do opróżnienia");
                string nrSer = Console.In.ReadLine();
                
                int nr=ZnajdzKontener(nrSer, kontenerList);

                if (nr == -1)
                {
                    Console.WriteLine("Niepoprawne dane");
                }
                else
                {
                    kontenerList[nr].Oproznij();
                }
              
            }break;
        }
}

static int ZnajdzKontener(string nrSer, List<Kontener> kontenerList)
{
    for (int i = 0; i < kontenerList.Count; i++)
    {
        if (kontenerList[i].NrSeryjny == nrSer)
        {
            return i;
        }
    }
    return -1;
}