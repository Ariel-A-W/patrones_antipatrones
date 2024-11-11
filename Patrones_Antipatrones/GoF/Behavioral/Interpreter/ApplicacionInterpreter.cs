namespace GoF.Behavioral.Interpreter
{
    public class ApplicacionInterpreter
    {
        public void Test()
        {
            // La expresión "3 + 5 - 2" se representa
            // como un árbol de sintaxis.
            IExpression expression = 
                new SubstractionExpression(
                    new AddExpression(
                        new NumberExpression(3),
                        new NumberExpression(5)
                    ),
                    new NumberExpression(2)
            );

            int resultado = expression.Interpret();
            // Salida: Result: 6            
            Console.WriteLine($"Resultado: {resultado}"); 
        }
    }
}
