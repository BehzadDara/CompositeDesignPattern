namespace CompositeDesignPattern
{
    public class ShapeGroup : IShape
    {
        private List<IShape> shapes = new List<IShape>();

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
