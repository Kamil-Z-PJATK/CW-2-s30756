﻿namespace APBD_CW_2;

public class KontenerL:Kontener, IHazardNotifier
{
    public bool CzyBezpieczny { get; set; }
    public KontenerL(double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, double maxLadownosc, bool czyBezpieczny) : base(masaKontenera, wysokoscKontenera, glembokoscKontenera, maxLadownosc, "L")
    {
        CzyBezpieczny = czyBezpieczny;
    }
    
   

    public override void Zaladuj(double masa)
    {
        if (MaxLadownosc<MasaLadunku+masa)
        {
            throw new OverfillException();
        };
        
        if (CzyBezpieczny)
        {
            if ((MaxLadownosc*0.90)<MasaLadunku+masa)
            {
                HazardNotifie();
            }
            else
            {
                MasaLadunku += masa;
            }
        }
        else
        {
            if ((MaxLadownosc * 0.50) < MasaLadunku + masa)
            {
                HazardNotifie();
            }
            else
            {
                MasaLadunku += masa;
            }
        }
    }

    public void HazardNotifie()
    {
        Console.WriteLine("HazardNotifie "+NrSeryjny);
        System.Threading.Thread.Sleep(1000);
    }

    public override string ToString()
    {
        return base.ToString() +" "+ CzyBezpieczny;
    }
}