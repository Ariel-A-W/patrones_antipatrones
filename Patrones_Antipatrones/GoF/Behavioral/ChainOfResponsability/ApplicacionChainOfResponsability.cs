namespace GoF.Behavioral.ChainOfResponsability
{
    public class ApplicacionChainOfResponsability
    {
        public void Test()
        {
            // Crear los manejadores
            SupportHandler basicHandler = new BasicSupportHandler();
            SupportHandler advancedHandler = new AdvancedSupportHandler();
            SupportHandler expertHandler = new ExpertSupportHandler();

            // Configurar la cadena de responsabilidad
            basicHandler.SetNextHandler(advancedHandler);
            advancedHandler.SetNextHandler(expertHandler);

            // Crear algunas solicitudes de soporte
            SupportRequest request1 = new SupportRequest("¿Cómo resetear mi contraseña?", 1);
            SupportRequest request2 = new SupportRequest("La App se rompe al iniciar.", 2);
            SupportRequest request3 = new SupportRequest("Pérdida de datos en el entorno.", 3);

            // Procesar las solicitudes
            basicHandler.HandleRequest(request1); // Manejado por Soporte Básico
            basicHandler.HandleRequest(request2); // Manejado por Soporte Avanzado
            basicHandler.HandleRequest(request3); // Manejado por Soporte Experto            
        }
    }
}
