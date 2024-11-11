namespace GoF.Creational.Builder
{
    public class AutomovilBuilder : IVehiculoBuilder
    {
        private Vehiculo vehiculo = new Vehiculo();

        public void BuildGPS()
        {
            vehiculo.GPS = true;
        }

        public void BuildMotor()
        {
            vehiculo.Motor = "Motor del automóvil";
        }

        public void BuildRuedas()
        {
            vehiculo.Ruedas = 4;
        }

        public Vehiculo GetVehiculo()
        {
            return vehiculo;
        }
    }
}
