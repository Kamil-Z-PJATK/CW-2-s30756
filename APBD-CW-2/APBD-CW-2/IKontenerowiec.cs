namespace APBD_CW_2;

public interface IKontenerowiec
{
    public void UsunKontener(Kontener kontener);
    public void ZamienKontener(string str1,Kontener kontener);
    public void Zaladuj(Kontener kontener);
    public void NaInnyStatek(IKontenerowiec kontenerowiec, string nrSeryjny);
    
}