namespace GoF.Behavioral.Visitor
{
    public class Archivo : IElement
    {
        public string? Nombre { get; }
        public int Tamaño { get; }

        public Archivo(string? nombre, int tamaño)
        {
            Nombre = nombre;
            Tamaño = tamaño;
        }
        public void Aceptar(IVisitor visitante)
        {
            visitante.Visitante(this);
        }
    }
}
