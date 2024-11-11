namespace GoF.Behavioral.State
{
    public interface IState
    {
        void InsertarFicha();
        void ExtraerFicha();
        void PresionarBoton();
        void Despachar();
    }
}
