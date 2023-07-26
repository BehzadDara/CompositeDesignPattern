using CompositeDesignPattern;

var shapeGroup = new ShapeGroup();

shapeGroup.Add(new Circle());
shapeGroup.Add(new Square());

shapeGroup.Move();