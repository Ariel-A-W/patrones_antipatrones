namespace GoF.Behavioral.ChainOfResponsability
{
    public class BasicSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest? supportRequest)
        {
            if (supportRequest!.Nivel <= 1)
                Console.WriteLine($"Soporte Básico: Manipulando solicitud " +
                    $"- {supportRequest.Mensaje}");
            else
                _supportHandler!.HandleRequest(supportRequest);
        }
    }
}
