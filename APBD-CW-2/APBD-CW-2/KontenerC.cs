namespace APBD_CW_2;

public class KontenerC: Kontener
{
    
    public string TypProdutu { get; set; }
    public double Temperatura { get; set; }
    
    private Dictionary<string, double> _mapaTypow= new Dictionary<string, double>();
    
    
    public KontenerC(double masaKontenera, double wysokoscKontenera, double glembokoscKontenera, double maxLadownosc, string typProdutu, double temperatura ) : base(masaKontenera, wysokoscKontenera, glembokoscKontenera, maxLadownosc, "C")
    {
        TypProdutu = typProdutu;
        Temperatura = temperatura;
        _mapaTypow.Add("Bananas", 13.3);
        _mapaTypow.Add("Chocolate", 18.0);
        _mapaTypow.Add("Fish", 2);
        _mapaTypow.Add("Meat", -15);
        _mapaTypow.Add("Ice cream", -18);
        _mapaTypow.Add("Frozen pizza", -30.0);
        _mapaTypow.Add("Cheese", 7.2);
        _mapaTypow.Add("Sausage", 5);
        _mapaTypow.Add("Butter", 20.5);
        _mapaTypow.Add("Eggs", 19);

        for (int i = 0; i < _mapaTypow.Count; i++)
        {
            if (_mapaTypow.ElementAt(i).Key.Equals(TypProdutu))
            {
                if (Temperatura<_mapaTypow.ElementAt(i).Value)
                {
                    Temperatura = _mapaTypow.ElementAt(i).Value;
                    
                }
            }
        }
        
        
    }
    
    
    
    
}