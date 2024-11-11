namespace GoF.Behavioral.State
{
    internal class SinStockEstado : IState
    {
        private MaquinaExpendedora? _maquina;

        public SinStockEstado(MaquinaExpendedora? maquina)
        {
            _maquina = maquina;
        }

        public void Despachar()
        {
            Console.WriteLine("Fuera de Stock.");
        }

        public void ExtraerFicha()
        {
            Console.WriteLine("No hay ficha para extraer.");
        }

        public void InsertarFicha()
        {
            Console.WriteLine("Fuera de Stock.");
        }

        public void PresionarBoton()
        {
            Console.WriteLine("Fuera de Stock.");
        }
    }
}