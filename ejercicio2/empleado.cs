
using System.Diagnostics;
using System.Security.Cryptography;

namespace Empleados{
    enum Cargos
    {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
    }

    class Empleado
    {
        const double EXTRA_MAX_POR_ANTIGUEDAD = 0.25;
        const double MULTIPLICADOR_EXTRA_POR_ANTIGUEDAD = 0.01;
        const double EXTRA_POR_ESTAR_CASADO = 150000;
        const double MULTIPLICADOR_EXTRA_POR_CARGO = 1.5;
        const int ANTIGUEDAD_MAX = 20;
        const int ANIOS_PARA_JUBILACION = 65;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        internal Cargos Cargo { get => cargo; set => cargo = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        public int Antiguedad()
        {
            int Antiguedad = 0;
            DateTime FechaActual = DateTime.Now;
            Antiguedad = FechaActual.Year - FechaIngreso.Year;
            return Antiguedad;
        }

        public int EdadEmpleado()
        {
            int edad;
            DateTime FechaActual = DateTime.Now;
            edad = FechaActual.Year - FechaNacimiento.Year;
            return edad;
        }

        public int AniosParaRetiro()
        {
            int aniosParaRetiro;
            aniosParaRetiro = ANIOS_PARA_JUBILACION - EdadEmpleado();
            return aniosParaRetiro;
        }

        public double CalcularSalario()
        {
            double salario=0;
            double adicional;
            if (Antiguedad()>ANTIGUEDAD_MAX)
            {
                adicional = sueldoBasico* EXTRA_MAX_POR_ANTIGUEDAD;
            }else
            {
                adicional =sueldoBasico * Antiguedad()* MULTIPLICADOR_EXTRA_POR_ANTIGUEDAD;
            }
            if(estadoCivil == 'c')
            {
                adicional = adicional + EXTRA_POR_ESTAR_CASADO;
            }

            if((cargo.ToString() == Cargos.Ingeniero.ToString()) || (cargo.ToString() == Cargos.Especialista.ToString()))
            {
                adicional = adicional * MULTIPLICADOR_EXTRA_POR_CARGO;
            }
            salario = sueldoBasico + adicional;
            return Math.Round(salario, 2);
        }

        public void mostrarEmpleado(int indiceEmpleado)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Los datos del empleado {indiceEmpleado + 1} son: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Edad: {EdadEmpleado()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Fecha de Nacimientos: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Estado Civil (c: casado, s: soltero): {EstadoCivil}");
            Console.WriteLine($"Fecha Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Sueldo Basico: ${SueldoBasico}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Antiguedad: {Antiguedad()} anios");
            Console.WriteLine($"Salario: ${CalcularSalario()}");
            Console.WriteLine($"Anios para el retiro: {AniosParaRetiro()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
        }

    }
}
