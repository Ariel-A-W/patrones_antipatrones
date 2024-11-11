namespace GoF.Behavioral.Visitor
{
    public class ApplicacionVisitor
    {
        public void Test()
        {
            // Crear una estructura de archivos
            var root = new Directorio("ruta");
            var file1 = new Archivo("archivo1.txt", 100);
            var file2 = new Archivo("archivo2.txt", 200);
            var subDir = new Directorio("subruta");
            var file3 = new Archivo("archivo3.txt", 300);

            subDir.AgregarElemento(file3);
            root.AgregarElemento(file1);
            root.AgregarElemento(file2);
            root.AgregarElemento(subDir);

            // Calcular el tamaño total
            var sizeVisitor = new TamanioVisitante();
            root.Aceptar(sizeVisitor);
            Console.WriteLine($"Total: {sizeVisitor.TotalTamanio}");

            // Imprimir nombres de archivos y directorios
            var nameVisitor = new NombreVisitante();
            root.Aceptar(nameVisitor);
        }
    }
}
