namespace GoF.Behavioral.ChainOfResponsability
{
    public abstract class SupportHandler
    {
        protected SupportHandler? _supportHandler;

        public void SetNextHandler(SupportHandler? supportHandler)
        {
            _supportHandler = supportHandler; 
        }

        public abstract void HandleRequest(SupportRequest? supportRequest);
    }
}
