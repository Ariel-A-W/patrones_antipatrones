namespace GoF.Structural.Adapter
{
    public class PayPalPayment
    {
        public void MakePayment(decimal monto)
        {
            Console.WriteLine($"Procesando el pago de $ {monto} mediante PayPal");
        }
    }
}
