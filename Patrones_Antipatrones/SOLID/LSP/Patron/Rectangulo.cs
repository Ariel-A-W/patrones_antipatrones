namespace Patrones_Antipatrones.SOLID.LSP.Patron;

public class Rectangulo : IFigura
{
    public virtual int Largo { get; set; }
    public virtual int Ancho { get; set; }
    public int CalcularArea()
    {
        return Largo * Ancho;         
    }
}
