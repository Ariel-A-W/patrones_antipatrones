namespace GoF.Structural.Composite
{
    public class CompositeGraphic : IGraphic
    {
        private List<IGraphic> _graphic = new List<IGraphic>();

        public void Add(IGraphic graphic)
        { 
            _graphic.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            _graphic.Remove(graphic);
        }

        public void Draw()
        {
            foreach (IGraphic graphic in _graphic)
            {
                graphic.Draw();
            }
        }
    }
}
