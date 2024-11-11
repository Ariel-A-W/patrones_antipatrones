namespace GoF.Creational.Builder
{
    public interface IVehiculoBuilder
    {
        void BuildMotor();
        void BuildRuedas();
        void BuildGPS();
        Vehiculo GetVehiculo();
    }
}
