namespace GoF.Structural.Adapter
{
    public class ApplicacionAdapter
    {
        public void Test()
        {
            // Crear una instancia de PayPalPayment
            PayPalPayment payPalPayment = new PayPalPayment();

            // Crear una instancia de PayPalAdapter pasando la instancia de PayPalPayment
            IPaymentProcessor paymentProcessor = new PayPalAdapter(payPalPayment);

            // Usar el adaptador para procesar el pago
            paymentProcessor.ProcessPayment(100.00m);
        }
    }
}
