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
    
    public Kontener(double masaLadunku, double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, string typ)
    {
        MasaLadunku = masaLadunku;
        WysokoscKontenera = wysokoscKontenera;
        MasaKontenera = masaKontenera;
        GlembokoscKontenera = glembokoscKontenera;
        this.typ = typ;
        NrSeryjny+="KON-";
        NrSeryjny+=this.typ+"-";
        nr += 1;
        NrSeryjny+=nr;
     
       
    }



    public abstract void Oproznij();

    public abstract void Zaladuj(double masa);
}