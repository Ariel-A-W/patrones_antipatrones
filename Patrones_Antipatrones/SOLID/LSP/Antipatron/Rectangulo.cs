namespace Patrones_Antipatrones.SOLID.LSP.Antipatron;

public class Rectangulo
{
    public virtual int Largo { get; set; }
    public virtual int Ancho { get; set; }

    public int CalcularArea() => Largo * Ancho;
}
