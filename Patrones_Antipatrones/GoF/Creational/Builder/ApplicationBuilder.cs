namespace GoF.Creational.Builder
{
    public class ApplicationBuilder
    {
        public void Test()
        {
            VehiculoDirector director = new VehiculoDirector();

            IVehiculoBuilder carBuilder = new AutomovilBuilder();
            director.Constructor(carBuilder);
            Vehiculo car = carBuilder.GetVehiculo();
            Console.WriteLine("Car built:");
            car.ShowInformacion();

            IVehiculoBuilder motorbikeBuilder = new MotocicletaBuilder();
            director.Constructor(motorbikeBuilder);
            Vehiculo motorbike = motorbikeBuilder.GetVehiculo();
            Console.WriteLine("\nMotorbike built:");
            motorbike.ShowInformacion();
        }
    }
}
