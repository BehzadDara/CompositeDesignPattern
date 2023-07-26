namespace CompositeDesignPattern
{
    public class ShapeGroup : IShape
    {
        private readonly List<IShape> Shapes = new();

        public void Add(IShape shape)
            => Shapes.Add(shape);

        public void Move()
        {
            foreach (IShape shape in Shapes)
            {
                shape.Move();
            }
        }
    }
}
