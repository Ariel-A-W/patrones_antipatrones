namespace GoF.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visitante(Archivo archivo);
        void Visitante(Directorio directorio);
    }
}
