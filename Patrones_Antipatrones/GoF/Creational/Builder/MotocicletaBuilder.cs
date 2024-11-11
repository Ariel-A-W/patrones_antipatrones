namespace GoF.Creational.Builder
{
    public class MotocicletaBuilder : IVehiculoBuilder
    {
        private Vehiculo vehiculo = new Vehiculo(); 

        public void BuildGPS()
        {
            vehiculo.GPS = false; ;
        }

        public void BuildMotor()
        {
            vehiculo.Motor = "Motor de la motocicleta";
        }

        public void BuildRuedas()
        {
            vehiculo.Ruedas = 2;
        }

        public Vehiculo GetVehiculo()
        {
            return vehiculo;
        }
    }
}
