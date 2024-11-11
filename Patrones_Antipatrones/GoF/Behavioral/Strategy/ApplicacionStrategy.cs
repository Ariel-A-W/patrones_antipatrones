namespace GoF.Behavioral.Strategy
{
    public class ApplicacionStrategy
    {
        public void Test()
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();

            // Pago con tarjeta de crédito
            paymentProcessor.HacerPagoStrategy(
                new CreditCardPayment("1234-5678-9012-3456", "Elisa Gómez Quesada"));
            paymentProcessor.ProcesarPagoStrategy(100.00m);

            // Pago con PayPal
            paymentProcessor.HacerPagoStrategy(
                new PayPalPayment("martin.mendez@gmail.com"));
            paymentProcessor.ProcesarPagoStrategy(150.00m);

            // Pago con criptomonedas
            paymentProcessor.HacerPagoStrategy(
                new CryptoPayment("1A2B3C4D5E6F"));
            paymentProcessor.ProcesarPagoStrategy(200.00m);
        }
    }
}
