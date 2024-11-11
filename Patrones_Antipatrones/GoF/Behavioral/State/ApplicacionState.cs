namespace GoF.Behavioral.State
{
    public class ApplicacionState
    {
        public void Test()
        {
            MaquinaExpendedora vendingMachine = new MaquinaExpendedora(3);

            // Intentar dispensar sin moneda
            vendingMachine.PresionarBoton();

            // Insertar moneda y dispensar
            vendingMachine.InsertarFicha();
            vendingMachine.PresionarBoton();

            // Insertar moneda y expulsar
            vendingMachine.InsertarFicha();
            vendingMachine.ExtraerFicha();

            // Insertar moneda y dispensar hasta que se agoten los productos
            vendingMachine.InsertarFicha();
            vendingMachine.PresionarBoton();

            vendingMachine.InsertarFicha();
            vendingMachine.PresionarBoton();

            // Intentar insertar moneda cuando la máquina está vacía
            vendingMachine.InsertarFicha();
        }
    }
}
