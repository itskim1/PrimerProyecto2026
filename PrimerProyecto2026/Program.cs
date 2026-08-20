using PrimerProyecto2026;

Console.WriteLine("Hello, World!");

//  TRABAJADOR 
Trabajador trabajador = new Trabajador();
trabajador.Nombres = "Hugo Felipe";
trabajador.Apellidos = "Torrico Márquez";
trabajador.Sueldo = 5000;

Trabajador trabajador1 = new Trabajador
{
    Nombres = "Juan José",
    Apellidos = "Torrico Márquez",
    Sueldo = 10000
};

Console.WriteLine("El sueldo neto es " + trabajador.calcularSueldoNeto());
Console.WriteLine("El sueldo neto es " + trabajador1.calcularSueldoNeto());

// ESTUDIANTE 
Estudiante estudiante1 = new Estudiante();
estudiante1.Nombres = "Alexander";
estudiante1.Apellidos = "Arce";
estudiante1.Nota = 15;

Console.WriteLine("El estudiante " + estudiante1.Nombres + " " + estudiante1.Apellidos + " está: " + estudiante1.Evaluacion());

//  RECTÁNGULO 
Rectangulo rect = new Rectangulo();

Console.WriteLine(" INGRESE LAS COORDENADAS DEL RECTÁNGULO ");

Console.WriteLine("Punto 1:");
Console.Write("  X1: "); rect.Punto1.X = Convert.ToDouble(Console.ReadLine());
Console.Write("  Y1: "); rect.Punto1.Y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Punto 2:");
Console.Write("  X2: "); rect.Punto2.X = Convert.ToDouble(Console.ReadLine());
Console.Write("  Y2: "); rect.Punto2.Y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Punto 3:");
Console.Write("  X3: "); rect.Punto3.X = Convert.ToDouble(Console.ReadLine());
Console.Write("  Y3: "); rect.Punto3.Y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Punto 4:");
Console.Write("  X4: "); rect.Punto4.X = Convert.ToDouble(Console.ReadLine());
Console.Write("  Y4: "); rect.Punto4.Y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n RESULTADOS ");
Console.WriteLine("Área del rectángulo: " + rect.CalcularArea());
Console.WriteLine("Perímetro del rectángulo: " + rect.CalcularPerimetro());

Console.Read();