namespace APBD_CW_2;

public class Kontenerowiec
{
    private List<Kontener> kontenerList;
    public double Predkosc{get;set;}
    public double MaxMasa{get;set;}
    public int MaxKon{get;set;}

    public string Nazwa{get;set;}
    private double _obecnaMasa;

    public Kontenerowiec(double predkosc, double maxMasa, int maxKon, string nazwa)
    {
        this.Predkosc = predkosc;
        this.MaxMasa = maxMasa;
        this.MaxKon = maxKon;
        kontenerList = new List<Kontener>();
        _obecnaMasa = 0;
        Nazwa = nazwa;
        
    }

    public void UsunKontener(Kontener kontener)
    {
        this.kontenerList.Remove(kontener);
    }

    public void ZamienKontener(string nr1, Kontener kontener)
    {
        for (int i = 0; i < this.kontenerList.Count; i++)
        {
            if (kontenerList[i].NrSeryjny == nr1)
            {
                kontenerList[i] = kontener;
                break;
            }
        }

        Console.WriteLine("Podano niepoprawny kontener");
    }

    public void Zaladuj(Kontener kontener)
    {
        _obecnaMasa = 0;
        for (int i = 0; i < kontenerList.Count; i++)
        {
            _obecnaMasa += kontenerList[i].MasaLadunku;
            _obecnaMasa += kontenerList[i].MasaKontenera;
        }
        _obecnaMasa /= 1000;
        if (MaxMasa>=_obecnaMasa+(kontener.MasaLadunku+kontener.MasaKontenera)/1000)
        {
            if (MaxKon>=kontenerList.Count+1)
            {
                kontenerList.Add(kontener);
            }
        }
    }


    public void Zaladuj(List<Kontener> kontenerl)
    {
        _obecnaMasa = 0;
        for (int i = 0; i < kontenerList.Count; i++)
        {
            _obecnaMasa += kontenerList[i].MasaLadunku;
            _obecnaMasa += kontenerList[i].MasaKontenera;
        }

        double masaDodana = 0;
        for (int i = 0; i < kontenerl.Count(); i++)
        {
            masaDodana += kontenerl[i].MasaLadunku;
            masaDodana+= kontenerl[i].MasaKontenera;
        }
        _obecnaMasa /= 1000;
        masaDodana /= 1000;
        if (MaxMasa >= masaDodana+_obecnaMasa)
        {
            if (MaxKon>=kontenerl.Count+kontenerList.Count)
            {
                kontenerList.AddRange(kontenerl);
            }
        }
    }

    public void NaInnyStatek(Kontenerowiec kontenerowiec, string nrSeryjny)
    {
        
        for (int i = 0; i < kontenerList.Count(); i++)
        {
            if( kontenerList[i].NrSeryjny == nrSeryjny)
            {
                kontenerowiec.Zaladuj(kontenerList[i]);
                kontenerList.RemoveAt(i);
                break;
            }
        }
        
    }

    public override string ToString()
    {
        return Nazwa + " (speed= "+Predkosc+" max Container number= "+MaxKon + " max Weight = "+MaxMasa+" )";
    }
    
    


}