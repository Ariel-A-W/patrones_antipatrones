namespace GoF.Creational.Prototype
{
    public class ApplicacionPrototype
    {
        public void Test()
        {
            // Crear una instancia de Circle
            Circulo originalCircle = new Circulo(10, "Red");
            originalCircle.ShowInformacion();

            // Clonar el Circle
            Circulo clonedCircle = originalCircle.Clone();
            clonedCircle.ShowInformacion();

            // Crear una instancia de Rectangle
            Rectangulo originalRectangle = new Rectangulo(20, 10, "Blue");
            originalRectangle.ShowInformacion();

            // Clonar el Rectangle
            Rectangulo clonedRectangle = originalRectangle.Clone();
            clonedRectangle.ShowInformacion();
        }
    }
}
