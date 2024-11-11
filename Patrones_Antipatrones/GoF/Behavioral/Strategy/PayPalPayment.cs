namespace GoF.Behavioral.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string? _email;

        public PayPalPayment(string? email)
        {
            _email = email;
        }

        public void Pay(decimal monto)
        {
            Console.WriteLine($"$ {monto} pago con PayPal.\n" +
                $"Cuenta: {_email}");
        }
    }
}
