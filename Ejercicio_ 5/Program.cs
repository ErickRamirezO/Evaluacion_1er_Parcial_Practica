using System;

class Program{

    class Estudiante   {
        public string Nombre;
        public int Edad;
        public double Calificacion;

        public Estudiante(string nombre, int edad, double calificacion) {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }
        public void MostrarInformacion() {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Calificacion: {Calificacion}");
        }
    }

    class EstudianteGraduado : Estudiante {
        public string Titulo;

        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo) : base(nombre, edad, calificacion){
            Titulo = titulo;
        }

        public void MostrarInformacionGraduado(){
            MostrarInformacion();
            Console.WriteLine($"Titulo: {Titulo}");
        }
    }

    public static void Main(string[] args)
    {
        EstudianteGraduado graduado1 = new EstudianteGraduado("Maria", 25, 18.0, "Ingeniero");
        graduado1.MostrarInformacionGraduado();
    }
}