namespace GoF.Creational.Singleton
{
    public class ApplicacionSingleton
    {
        public void Test()
        {
            // Obtener la instancia única del Singleton y llamar a un método
            Singleton singleton1 = Singleton.Instancia;
            singleton1.HacerAlgo();

            // Obtener la instancia única del Singleton y llamar a un método
            Singleton singleton2 = Singleton.Instancia;
            singleton2.HacerAlgo();

            // Verificar si ambas instancias son la misma
            Console.WriteLine("Singlenton");
            if (singleton1 == singleton2)
                Console.WriteLine("Ambas instancias son la misma.");
            else
                Console.WriteLine("La instancia es diferente.");

            // Caso para una clase de tipo No Singleton.
            NoSingleton nosingleton1 = NoSingleton.Instancia;
            nosingleton1.HacerAlgo();

            NoSingleton nosingleton2 = NoSingleton.Instancia;
            nosingleton2.HacerAlgo();

            Console.WriteLine("NoSinglenton");
            if (nosingleton1 == nosingleton2)
                Console.WriteLine("Ambas instancias son la misma.");
            else
                Console.WriteLine("La instancia es diferente.");

        }

    }
}
