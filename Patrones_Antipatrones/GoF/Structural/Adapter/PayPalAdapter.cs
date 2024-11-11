namespace GoF.Structural.Adapter
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalPayment _payPalPayment;

        public PayPalAdapter(PayPalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public void ProcessPayment(decimal monto)
        {
            _payPalPayment.MakePayment(monto);
        }
    }
}
