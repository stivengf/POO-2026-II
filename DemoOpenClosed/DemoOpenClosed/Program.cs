using DemoOpenClosed;


Area_calculator calculator = new Area_calculator();

Circle circle1 = new Circle();
circle1.Radious = 2;

Circle circle2 = new Circle();
circle2.Radious = 3;

Circle circle3 = new Circle();
circle3.Radious = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangle triangulo1 = new Triangle();
triangulo1.Base = 5;
triangulo1.High = 2;

Triangle triangulo2 = new Triangle();
triangulo2.Base = 4;
triangulo2.High = 3;

Triangle triangulo3 = new Triangle();
triangulo3.Base = 8;
triangulo3.High = 8;

Polygone poligono1 = new Polygone();
poligono1.Apothem = 10;
poligono1.Size = 5;
poligono1.Num_Size = 10;

Polygone poligono2 = new Polygone();
poligono2.Apothem = 1;
poligono2.Size = 8;
poligono2.Num_Size = 6;

Polygone poligono3 = new Polygone();
poligono1.Apothem = 14;
poligono1.Size = 6;
poligono1.Num_Size = 8;

Trapeze trapecio1 = new Trapeze();
trapecio1.High = 5;
trapecio1.Shorter_Base = 4;
trapecio1.Longer_Base = 10;

Trapeze trapecio2 = new Trapeze();
trapecio1.High = 4;
trapecio1.Shorter_Base = 7;
trapecio1.Longer_Base = 20;

Trapeze trapecio3 = new Trapeze();
trapecio1.High = 7;
trapecio1.Shorter_Base = 6;
trapecio1.Longer_Base = 11;
List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(poligono1);
shapes.Add(poligono2);
shapes.Add(poligono3);
shapes.Add(trapecio1);
shapes.Add(trapecio2);
shapes.Add(trapecio1);


var resultTotalArea = calculator.Area_Total(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");

