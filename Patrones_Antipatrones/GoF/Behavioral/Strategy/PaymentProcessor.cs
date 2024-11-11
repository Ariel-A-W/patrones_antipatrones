namespace GoF.Behavioral.Strategy
{
    public class PaymentProcessor
    {
        private IPaymentStrategy? _paymentStrategy;

        public void HacerPagoStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcesarPagoStrategy(decimal monto)
        {
            if (_paymentStrategy == null)
                throw new InvalidOperationException("El pago ha sido abortado.");

            _paymentStrategy.Pay(monto);
        }
    }
}
