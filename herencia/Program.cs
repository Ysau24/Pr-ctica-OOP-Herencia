using System;
using System.Collections.Generic;

// Clase abstracta Shape
public abstract class Shape
{
    // Campos protegidos para que las clases derivadas puedan acceder
    protected double width;
    protected double height;

    // Constructor para inicializar los campos
    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Método abstracto para calcular el área
    public abstract double CalculateSurface();
}

// Clase Rectangle que hereda de Shape
public class Rectangle : Shape
{
    // Constructor que llama al constructor base
    public Rectangle(double width, double height) : base(width, height) { }

    // Implementación del método CalculateSurface para el área del rectángulo
    public override double CalculateSurface()
    {
        return width * height;
    }
}

// Clase Triangle que hereda de Shape
public class Triangle : Shape
{
    // Constructor que llama al constructor base
    public Triangle(double width, double height) : base(width, height) { }

    // Implementación del método CalculateSurface para el área del triángulo
    public override double CalculateSurface()
    {
        return (width * height) / 2;
    }
}

// Clase Circle que hereda de Shape
public class Circle : Shape
{
    // Constructor que llama al constructor base, el ancho y alto son el radio
    public Circle(double radius) : base(radius, radius) { }

    // Implementación del método CalculateSurface para el área del círculo
    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(width, 2); // El área de un círculo es pi * radio^2
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una matriz de diferentes formas
        Shape[] shapes = new Shape[]
        {
            new Rectangle(10, 5),   // Rectángulo de ancho 10 y alto 5
            new Triangle(4, 7),     // Triángulo de base 4 y altura 7
            new Circle(3),          // Círculo de radio 3
            new Rectangle(6, 9),    // Otro rectángulo
            new Triangle(8, 2)      // Otro triángulo
        };

        // Crear una lista para almacenar las áreas
        List<double> areas = new List<double>();

        // Calcular el área de cada forma y almacenarla en la lista
        foreach (var shape in shapes)
        {
            areas.Add(shape.CalculateSurface());
        }

        // Mostrar las áreas calculadas
        for (int i = 0; i < areas.Count; i++)
        {
            Console.WriteLine($"El área de la forma {i + 1} es: {areas[i]:F2}");
        }


        

    }
}
