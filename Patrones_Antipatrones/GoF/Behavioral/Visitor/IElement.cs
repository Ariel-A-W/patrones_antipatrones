namespace GoF.Behavioral.Visitor
{
    public interface IElement
    {
        void Aceptar(IVisitor visitante);
    }
}
