namespace APBD_CW_2;

public class KontenerL:Kontener
{
    public bool CzyBezpieczny { get; set; }
    public KontenerL(double masaLadunku, double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, bool czyBezpieczny) : base(masaLadunku, masaKontenera, wysokoscKontenera, glembokoscKontenera,"L")
    {
        CzyBezpieczny = czyBezpieczny;
       
    }

   

    public override void Oproznij()
    {
        throw new NotImplementedException();
    }

    public override void Zaladuj(double masa)
    {
        throw new NotImplementedException();
    }
}