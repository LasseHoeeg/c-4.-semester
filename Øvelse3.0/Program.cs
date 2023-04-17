

using Øvelse3._0;

Shape[] shapes = new Shape[4];

Circle c1 = new Circle(2, 2, 6);
Rectangle r1 = new Rectangle(2, 4, 6, 8);
//Shape s1 = new Shape(2,2);
//Shape s2 = new Shape();
shapes[0] = c1;
shapes[1] = r1;
//shapes[2] = s2;
//shapes[3] = s1;

for (int i = 0;i < shapes.Length; i++)
{
    Console.WriteLine(shapes[i].ToString());
    Console.WriteLine(shapes[i].area());
}

