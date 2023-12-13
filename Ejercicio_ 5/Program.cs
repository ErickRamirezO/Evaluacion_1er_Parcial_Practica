using System;

class Program{

    class Estudiante   {
        //Propiedades de la clase estudiante
        public string Nombre;
        public int Edad;
        public double Calificacion;
        //Constructor que inicializa todas las propiedades de la clase estudiante
        public Estudiante(string nombre, int edad, double calificacion) {
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }
        //Método que muestra toda la información del estudiante
        public void MostrarInformacion() {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Calificacion: {Calificacion}");
        }
    }
    //Clase EstudianteGraduado que hereda de la clase Estudiante
    class EstudianteGraduado : Estudiante {
        public string Titulo;
        //Constructor de la clase que inicializa la propiedad título
        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo) : base(nombre, edad, calificacion){
            Titulo = titulo;
        }
        //Método que muestra toda la información del estudiante junto con la nueva propiedad título
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