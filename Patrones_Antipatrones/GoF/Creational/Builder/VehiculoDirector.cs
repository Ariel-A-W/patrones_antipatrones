namespace GoF.Creational.Builder
{
    public class VehiculoDirector
    {
        public void Constructor(IVehiculoBuilder vehiculoBuilder) 
        {
            vehiculoBuilder.BuildMotor();
            vehiculoBuilder.BuildRuedas();
            vehiculoBuilder.BuildGPS(); 
        }
    }
}
