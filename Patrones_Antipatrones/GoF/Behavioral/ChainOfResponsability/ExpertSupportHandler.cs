namespace GoF.Behavioral.ChainOfResponsability
{
    public class ExpertSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest? supportRequest)
        {
            if (supportRequest!.Nivel <= 3)
                Console.WriteLine($"Soporte Experto: Manipulado solicitud " +
                    $"- {supportRequest.Mensaje}");
        }
    }
}
