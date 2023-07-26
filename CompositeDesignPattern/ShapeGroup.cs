namespace CompositeDesignPattern
{
    public class ShapeGroup : IShape
    {
        private List<IShape> shapes = new();

        public void Add(IShape shape)
            => shapes.Add(shape);

        public void Move()
        {
            foreach (IShape shape in shapes)
            {
                shape.Move();
            }
        }
    }
}
