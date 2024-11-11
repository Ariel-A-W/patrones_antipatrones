namespace GoF.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton? instancia = null; 
        private static readonly object controlBloqueo = new object();
        private Singleton() { } 

        public static Singleton Instancia 
        {
            get 
            {
                if (instancia == null)
                {
                    lock (controlBloqueo)
                    {
                        if (instancia == null)
                        {
                            instancia = new Singleton();
                        }                            
                    }
                }
                return instancia;
            }
        }

        public void HacerAlgo()
        {
            Console.WriteLine("La instancia Singleton está trabajando.");
        }
    }
}
