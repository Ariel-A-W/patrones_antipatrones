namespace GoF.Behavioral.Visitor
{
    internal class NombreVisitante : IVisitor
    {
        public void Visitante(Archivo archivo)
        {
            Console.WriteLine($"Archivo: {archivo.Nombre}");
        }

        public void Visitante(Directorio directorio)
        {
            Console.WriteLine($"Directorio: {directorio.Nombre}");
        }
    }
}
