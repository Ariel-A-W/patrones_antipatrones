namespace GoF.Structural.Composite
{
    public class ApplicacionComposite
    {
        public void Test()
        {
            // Crear gráficos individuales (hojas)
            IGraphic circulo1 = new Circulo();
            IGraphic circulo2 = new Circulo();
            IGraphic cuadrado1 = new Cuadrado();

            // Crear un compuesto gráfico y agregar hojas
            CompositeGraphic composite1 = new CompositeGraphic();
            composite1.Add(circulo1);
            composite1.Add(circulo2);

            // Crear otro compuesto gráfico y agregar hojas y otro compuesto
            CompositeGraphic composite2 = new CompositeGraphic();
            composite2.Add(cuadrado1);
            composite2.Add(composite1);

            // Dibujar todos los gráficos
            composite2.Draw();
        }
    }
}
