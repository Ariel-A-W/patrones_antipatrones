namespace Patrones_Antipatrones.SOLID.LSP.Antipatron;

public class Cuadrado : Rectangulo
{
    public override int Largo { 
        set { base.Largo = base.Ancho = value; } 
    }
    public override int Ancho { 
        set { base.Largo = base.Ancho = value; } 
    }
}
