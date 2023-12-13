using System;

class Program {

  class Estudiante{
      //Propiedades públicas
      public string Nombre;
      public int Edad;
      public double Calificacion;

      //Constructor que inicializa todas las propiedades
      public Estudiante(string nombre, int edad, double calificacion){
          Nombre = nombre;
          Edad = edad;
          Calificacion = calificacion;
      }
  }

  public static void Main (string[] args) {
    //Creación del objeto estudiante
    Estudiante estudiante1 = new Estudiante("Juan", 20 , 15.0);
    Console.WriteLine ($"Estudiante\nNombre: {estudiante1.Nombre}, Edad: {estudiante1.Edad}, Calificacion: {estudiante1.Calificacion}");
  }
}