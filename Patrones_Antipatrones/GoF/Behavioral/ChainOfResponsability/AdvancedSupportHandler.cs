namespace GoF.Behavioral.ChainOfResponsability
{
    public class AdvancedSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest? supportRequest)
        {
            if (supportRequest!.Nivel <= 2)
                Console.WriteLine($"Soporte Avanzado: Manipulado solicitud " +
                    $"- {supportRequest.Mensaje}");
            else if(_supportHandler != null)
                _supportHandler.HandleRequest(supportRequest);
        }
    }
}
