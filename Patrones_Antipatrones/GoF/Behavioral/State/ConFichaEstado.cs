namespace GoF.Behavioral.State
{
    internal class ConFichaEstado : IState
    {
        private MaquinaExpendedora? _maquina;

        public ConFichaEstado(MaquinaExpendedora? maquina)
        {
            _maquina = maquina;
        }

        public void Despachar()
        {
            Console.WriteLine("No hay item para desapachar.");
        }

        public void ExtraerFicha()
        {
            Console.WriteLine("Ficha eyectada.");
            _maquina!.AjustarState(_maquina.SinFichaEstado!);

        }

        public void InsertarFicha()
        {
            Console.WriteLine("La ficha está inserta y lista.");
        }

        public void PresionarBoton()
        {
            Console.WriteLine($"Botón presionado.");
            if (_maquina!.EstaVacio())
                _maquina.AjustarState(_maquina.SinStockEstado!);
            else 
                _maquina.AjustarState(_maquina.DespachandoEstado!);
        }
    }
}