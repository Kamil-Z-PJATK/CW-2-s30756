namespace APBD_CW_2;

public class Kontenerowiec:IKontenerowiec
{
    private List<Kontener> _kontenerList;
   
    public double Predkosc{get;set;}
    public double MaxMasa{get;set;}
    public int MaxKon{get;set;}
    
    
    
    public string Nazwa{get;set;}
    private double _obecnaMasa;

    public Kontenerowiec(double predkosc, double maxMasa, int maxKon, string nazwa)
    {
        Predkosc = predkosc;
        MaxMasa = maxMasa;
        MaxKon = maxKon;
        _kontenerList = new List<Kontener>();
        _obecnaMasa = 0;
        Nazwa = nazwa;
        
    }

    public void UsunKontener(Kontener kontener)
    {
        _obecnaMasa -=(kontener.MasaKontenera+kontener.MasaLadunku)/1000;
        this._kontenerList.Remove(kontener);
    }

    public void ZamienKontener(string nr1, Kontener kontener)
    {
        for (int i = 0; i < this._kontenerList.Count; i++)
        {
            if (_kontenerList[i].NrSeryjny == nr1)
            {
                _kontenerList[i] = kontener;
                break;
            }
        }

       
    }

    public void Zaladuj(Kontener kontener) 
    {
       
        if (MaxMasa<(_obecnaMasa+(kontener.MasaLadunku+kontener.MasaKontenera)/1000) || MaxKon < _kontenerList.Count+1)
        {
            throw new OverfillException();
        }
        else
        {
            _obecnaMasa += (kontener.MasaLadunku + kontener.MasaKontenera) / 1000;
            if (MaxKon>=_kontenerList.Count+1)
            {
                _kontenerList.Add(kontener);
            }
        }
    }


    public void Zaladuj(List<Kontener> kontenerl)
    {
        try
        {
            foreach (var j in kontenerl)
            {
                Zaladuj(j);
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void NaInnyStatek(IKontenerowiec kontenerowiec, string nrSeryjny)
    {
        
        for (int i = 0; i < _kontenerList.Count(); i++)
        {
            if( _kontenerList[i].NrSeryjny == nrSeryjny)
            {
                kontenerowiec.Zaladuj(_kontenerList[i]);
                _kontenerList.RemoveAt(i);
                break;
            }
        }
        
    }

    public override string ToString()
    {
        return Nazwa + " (speed= "+Predkosc+" max Container number= "+MaxKon + " max Weight = "+MaxMasa+" )";
    }

    public void ShowList()
    {
        foreach (var j in _kontenerList)
        {
            Console.WriteLine(j);
            
        }
    }
    
    


}