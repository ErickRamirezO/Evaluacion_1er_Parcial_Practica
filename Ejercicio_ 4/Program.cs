using System;

class Program{

    class Estudiante   {
        //Propiedades de la clase estudiante
        public string Nombre;
        public int Edad;
        public double Calificacion;
        //Constructor que inicializa todas las propiedades de la clase
        public Estudiante(string nombre, int edad, double calificacion) {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }
        //Método para mostrar toda la información del estudiante
        public void MostrarInformacion() {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Calificacion: {Calificacion}");
        }
    }

    public static void Main(string[] args)
    {
        Estudiante estudiante1 = new Estudiante("Juan", 20, 15.0);
        estudiante1.MostrarInformacion();
    }
}