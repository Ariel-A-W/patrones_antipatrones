using System.Xml.Linq;

namespace GoF.Behavioral.Visitor
{
    public class Directorio : IElement
    {
        public string? Nombre { get; }
        public List<IElement>? Elementos { get; }

        public Directorio(string? nombre)
        {
            Nombre = nombre;
            Elementos = new List<IElement>();
        }
        public void AgregarElemento(IElement elemento)
        { 
            Elementos!.Add(elemento);
        }
        public void Aceptar(IVisitor visitante)
        {
            visitante.Visitante(this);
            foreach (var elemento in Elementos)
            { 
                elemento.Aceptar(visitante);
            }
        }
    }
}
