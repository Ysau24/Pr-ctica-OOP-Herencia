using System;
using System.Collections.Generic;

// Clase base Empleado
abstract class Empleado
{
    public string Nombre { get; set; }
    public bool AlcanzóMeta { get; set; }

    // Método abstracto para calcular salario
    public abstract decimal CalcularSalario();
}

// Clase para Docente por Hora
class DocentePorHora : Empleado
{
    public int HorasTrabajadas { get; set; }
    public decimal TarifaPorHora { get; set; } = 800;  // Tarifa fija por hora

    public override decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}

// Clase para Docente de Contrato Fijo
class DocenteContratoFijo : Empleado
{
    public decimal SalarioFijo { get; set; }

    public override decimal CalcularSalario()
    {
        return AlcanzóMeta ? SalarioFijo : SalarioFijo / 2;
    }
}

// Clase para Empleado Administrativo
class EmpleadoAdministrativo : Empleado
{
    public decimal SalarioBase { get; set; }

    public override decimal CalcularSalario()
    {
        return AlcanzóMeta ? SalarioBase : SalarioBase / 2;
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Crear lista de empleados
        List<Empleado> empleados = new List<Empleado>
        {
            new DocentePorHora { Nombre = "Juan", HorasTrabajadas = 30 },
            new DocenteContratoFijo { Nombre = "Ana", SalarioFijo = 20000, AlcanzóMeta = true },
            new EmpleadoAdministrativo { Nombre = "Pedro", SalarioBase = 15000, AlcanzóMeta = false }
        };

        // Calcular y mostrar salarios
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"{empleado.Nombre} tiene un salario mensual de: {empleado.CalcularSalario()}");
        }

    }
}
