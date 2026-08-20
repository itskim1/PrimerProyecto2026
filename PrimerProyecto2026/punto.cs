namespace PrimerProyecto2026
{
    public class Punto
    {
        // Propiedades para representar una coordenada (X, Y)
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor vacío
        public Punto() { }

        // Constructor con parámetros 
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Método para calcular la distancia desde este punto hacia otro punto
        public double CalcularDistancia(Punto otroPunto)
        {
            return System.Math.Sqrt(System.Math.Pow(otroPunto.X - this.X, 2) + System.Math.Pow(otroPunto.Y - this.Y, 2));
        }
    }
}