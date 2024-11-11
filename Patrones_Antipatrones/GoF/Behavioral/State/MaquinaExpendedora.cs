namespace GoF.Behavioral.State
{
    public class MaquinaExpendedora
    {
        private IState? _state; 
        public IState? SinFichaEstado { get; }
        public IState? ConFichaEstado { get; }
        public IState? DespachandoEstado { get; }
        public IState? SinStockEstado { get; }
    
        public int Contar { get; private set; }

        public MaquinaExpendedora(int itemContar)
        {
            SinFichaEstado = new SinFichaEstado(this);
            ConFichaEstado = new ConFichaEstado(this);
            DespachandoEstado = new DespachandoEstado(this);
            SinStockEstado = new SinStockEstado(this);

            Contar = itemContar;
            _state = itemContar > 0 ? SinFichaEstado : SinStockEstado;
        }

        public void AjustarState(IState state) => _state = state; 

        public void InsertarFicha() => _state!.InsertarFicha(); 

        public void ExtraerFicha() => _state!.ExtraerFicha();

        public void PresionarBoton()
        {
            _state!.PresionarBoton();
            _state.Despachar();
        }

        public void ExtraerItem()
        {
            if (Contar > 0)
            {
                Contar--;
                Console.WriteLine("Se ha expendido un item.");
            }
        }

        public bool EstaVacio() => Contar == 0; 
    }
}
