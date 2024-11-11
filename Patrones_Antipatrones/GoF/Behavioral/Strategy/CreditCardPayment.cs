namespace GoF.Behavioral.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string? _cardNumber;
        private string? _cardHolderName;

        public CreditCardPayment(string? cardNumber, string? cardHolderName)
        {
            _cardNumber = cardNumber;
            _cardHolderName = cardHolderName;
        }

        public void Pay(decimal monto)
        {
            Console.WriteLine($"$ {monto} pago usando Tarjeta Crédito.\n" +
                $"Portador: {_cardHolderName}");
        }
    }
}
