namespace GoF.Behavioral.State
{
    internal class SinFichaEstado : IState
    {
        private MaquinaExpendedora? _maquina;

        public SinFichaEstado(MaquinaExpendedora? maquina)
        {
            _maquina = maquina;
        }

        public void Despachar()
        {
            Console.WriteLine("Inserte una Ficha primero.");
        }

        public void ExtraerFicha()
        {
            Console.WriteLine("Ficha extraída.");
        }

        public void InsertarFicha()
        {
            Console.WriteLine("Ficha insertada.");
            _maquina!.AjustarState(_maquina.ConFichaEstado!);
        }

        public void PresionarBoton()
        {
            Console.WriteLine("Inserte una Ficha primero.");
        }
    }
}