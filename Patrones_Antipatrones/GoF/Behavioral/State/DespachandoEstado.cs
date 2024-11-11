namespace GoF.Behavioral.State
{
    internal class DespachandoEstado : IState
    {
        private MaquinaExpendedora? _maquina;

        public DespachandoEstado(MaquinaExpendedora? maquina)
        {
            _maquina = maquina;
        }

        public void Despachar()
        {
            _maquina!.ExtraerItem();
            if (_maquina.EstaVacio())
                _maquina.AjustarState(_maquina.SinStockEstado!);
            else 
                _maquina.AjustarState(_maquina.SinFichaEstado!);
        }

        public void ExtraerFicha()
        {
            Console.WriteLine("No puede extraer la ficha, despachado en proceso.");
        }

        public void InsertarFicha()
        {
            Console.WriteLine($"Por favor espere, despachado en proceso.");
        }

        public void PresionarBoton()
        {
            Console.WriteLine("Listo para despachar.");
        }
    }
}