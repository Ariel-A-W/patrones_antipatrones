namespace GoF.Creational.Singleton
{
    public class NoSingleton
    {
        private static NoSingleton? instancia = null;

        public NoSingleton() { }

        public static NoSingleton Instancia
        {
            get
            {
                instancia = new NoSingleton();
                return instancia;
            }
        }

        public void HacerAlgo()
        {
            Console.WriteLine("La instancia NoSingleton está trabajando.");
        }
    }
}
