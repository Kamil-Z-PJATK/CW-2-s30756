namespace APBD_CW_2;

public abstract class Kontener:IKontener
{
    protected static int nr;

    protected string typ;
    public string NrSeryjny { get; set; }
    public double MasaLadunku { get; set; }
    public double WysokoscKontenera { get; set; }
    public double MasaKontenera { get; set; }
    public double GlembokoscKontenera { get; set; }
    public double MaxLadownosc{get;set;}
    public Kontener( double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, double maxLadownosc,string typ)
    {
        MasaLadunku = 0;
        WysokoscKontenera = wysokoscKontenera;
        MasaKontenera = masaKontenera;
        GlembokoscKontenera = glembokoscKontenera;
        MaxLadownosc = maxLadownosc;
        this.typ = typ;
        NrSeryjny+="KON-";
        NrSeryjny+=this.typ+"-";
        nr += 1;
        NrSeryjny+=nr;
     
       
    }



    public virtual void Oproznij()
    {
        MasaLadunku = 0;
    }

    
    public virtual void Zaladuj(double masa)
    {
        
        
        if (MaxLadownosc<MasaLadunku+masa)
        {
            throw new OverfillException();
        }
        else
        {
            MasaLadunku += masa;
        }
        
       
    }

    public override string ToString()
    {
        return NrSeryjny + " " + MasaLadunku + "/" + MaxLadownosc;
    }


}