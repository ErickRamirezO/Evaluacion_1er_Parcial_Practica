using System;

class Program {

  class Estudiante{
      public string Nombre;
      public int Edad;
      public double Calificacion;

      public Estudiante()
      {
      }

      public Estudiante(string nombre, int edad, double calificacion){
          Nombre = nombre;
          Edad = edad;
          Calificacion = calificacion;
      }
  }

  public static void Main (string[] args) {
    Estudiante estudiante1 = new Estudiante("Juan", 20 , 15.0);
    Console.WriteLine ($"Estudiante\nNombre: {estudiante1.Nombre}, Edad: {estudiante1.Edad}, Calificacion: {estudiante1.Calificacion}");
  }
}