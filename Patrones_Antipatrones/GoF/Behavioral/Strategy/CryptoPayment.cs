namespace GoF.Behavioral.Strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        private string? _walletAddress;

        public CryptoPayment(string? walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void Pay(decimal monto)
        {
            Console.WriteLine($"$ {monto} pago con Criptomoneda.\n" +
                $"Billetera: {_walletAddress}");
        }
    }
}
