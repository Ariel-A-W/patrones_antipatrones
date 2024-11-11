namespace GoF.Behavioral.ChainOfResponsability
{
    public class SupportRequest
    {
        public string? Mensaje { get; }
        public int Nivel { get; }

        public SupportRequest(string? mensaje, int nivel)
        {
            Mensaje = mensaje;
            Nivel = nivel;
        }
    }
}
