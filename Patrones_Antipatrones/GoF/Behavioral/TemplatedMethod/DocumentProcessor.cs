namespace GoF.Behavioral.TemplatedMethod
{
    public abstract class DocumentProcessor
    {
        public void ProcessDocument()
        {
            OpenDcoument();
            ReadDcoument();
            CloseDcoument();
        }

        protected abstract void OpenDcoument();
        protected abstract void ReadDcoument();
        protected abstract void CloseDcoument();
    }
}
