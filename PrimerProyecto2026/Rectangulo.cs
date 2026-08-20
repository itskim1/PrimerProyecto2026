using System;

namespace PrimerProyecto2026
{
    public class Rectangulo
    {
        // 4 Propiedades de tipo Punto
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }
        public Punto Punto4 { get; set; }

        // Constructor para inicializar los puntos y evitar errores de referencia nula
        public Rectangulo()
        {
            Punto1 = new Punto();
            Punto2 = new Punto();
            Punto3 = new Punto();
            Punto4 = new Punto();
        }

        // Método para calcular el Área utilizando la distancia entre Puntos
        public double CalcularArea()
        {
            double baseRect = Punto1.CalcularDistancia(Punto2);
            double alturaRect = Punto2.CalcularDistancia(Punto3);
            return baseRect * alturaRect;
        }

        // Método para calcular el Perímetro
        public double CalcularPerimetro()
        {
            double baseRect = Punto1.CalcularDistancia(Punto2);
            double alturaRect = Punto2.CalcularDistancia(Punto3);
            return 2 * (baseRect + alturaRect);
        }
    }
}