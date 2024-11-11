namespace GoF.Structural.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal monto);
    }
}
