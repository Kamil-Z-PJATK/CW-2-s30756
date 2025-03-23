namespace APBD_CW_2;

public class Kontenerowiec
{
    private List<Kontener> kontenerList;
    public double Predkosc{get;set;}
    public double MaxMasa{get;set;}
    public int MaxKon{get;set;}

    private double _obecnaMasa;

    public Kontenerowiec(double Predkosc, double MaxMasa, int MaxKon)
    {
        this.Predkosc = Predkosc;
        this.MaxMasa = MaxMasa;
        this.MaxKon = MaxKon;
        kontenerList = new List<Kontener>();
        _obecnaMasa = 0;
    }

    public void UssunKontener(Kontener kontener)
    {
        this.kontenerList.Remove(kontener);
    }

    public void ZamienKontener(Kontener kontener, Kontener kontener2)
    {
        for (int i = 0; i < this.kontenerList.Count; i++)
        {
            if (kontenerList[i].NrSeryjny == kontener.NrSeryjny)
            {
                kontenerList[i] = kontener2;
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
    
    


}