namespace GoF.Behavioral.Visitor
{
    public class TamanioVisitante : IVisitor
    {
        public int TotalTamanio { get; private set; }

        public void Visitante(Archivo archivo)
        {
            TotalTamanio += archivo.Tamaño;
        }

        public void Visitante(Directorio directorio)
        {
            // No se programa nada aquí.
        }
    }
}
