namespace Patrones_Antipatrones.SOLID.LSP.Patron;

public class Cuadrado : IFigura
{
    public virtual int Lado { get; set; }
    public int CalcularArea()
    {
        return Lado * Lado;
    }
}
