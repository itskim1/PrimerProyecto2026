namespace PrimerProyecto2026
{
    public class Estudiante
    {
        // Propiedades
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public double Nota { get; set; }

        // Función para evaluar el estado
        public string Evaluacion()
        {
            if (Nota > 14)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }
    }
}