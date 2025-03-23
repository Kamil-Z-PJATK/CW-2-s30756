namespace APBD_CW_2;

public class KontenerG:Kontener,IHazardNotifier
{
    public KontenerG(double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, double maxLadownosc) : base(masaKontenera, wysokoscKontenera, glembokoscKontenera, maxLadownosc, "G")
    {
        
    }

    public override void Oproznij()
    {
        MasaLadunku*=0.05;
    }

    public override void Zaladuj(double masa)
    {
        base.Zaladuj(masa);
        MasaLadunku+=masa;
    }

    public void HazardNotifie()
    {
        Console.WriteLine("HazardNotifie "+NrSeryjny);
    }

    
}