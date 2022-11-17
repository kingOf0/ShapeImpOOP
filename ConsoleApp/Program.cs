using ConsoleApp;
using ConsoleApp.geo;

List<Shape> list = new List<Shape>();

Rectangle rectangle = new Rectangle()
{
    Height = 10,
    Weight = 10
};
list.Add(rectangle);

Circle circle = new Circle()
{
    Radius = 10
};
list.Add(circle);

Circle circle2 = new Circle()
{
    Radius = 20,
};

Circle circle3 = new Circle()
{
    Radius = 30,
};

Cylinder cylinder = new Cylinder()
{
    Radius = 10,
    Height = 10
};
list.Add(cylinder);


foreach (var shape in list)
{
    shape.Draw();
}