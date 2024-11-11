namespace GoF.Behavioral.Interpreter
{
    public class SubstractionExpression : IExpression
    {
        private IExpression? _leftExpression;
        private IExpression? _rightExpression;

        public SubstractionExpression(
             IExpression? leftExpresion,
             IExpression? rightExpression
        )
        {
            _leftExpression = leftExpresion;
            _rightExpression = rightExpression;
        }
        public int Interpret()
        {
            return
                _leftExpression!.Interpret()
                - _rightExpression!.Interpret();
        }
    }
}
