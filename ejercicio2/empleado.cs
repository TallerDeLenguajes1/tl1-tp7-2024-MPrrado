
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

        public int Antiguedad(DateTime FechaIngreso)
        {
            int Antiguedad = 0;
            DateTime FechaActual = DateTime.Now;
            Antiguedad = FechaActual.Year - FechaIngreso.Year;
            return Antiguedad;
        }

        public int EdadEmpleado(DateTime FechaNacimiento)
        {
            int edad;
            DateTime FechaActual = DateTime.Now;
            edad = FechaActual.Year - FechaNacimiento.Year;
            return edad;
        }

        public int AniosParaRetiro(DateTime FechaIngreso)
        {
            int aniosParaRetiro;
            aniosParaRetiro = ANIOS_PARA_JUBILACION - Antiguedad(FechaIngreso);
            return aniosParaRetiro;
        }

        public double CalcularSalario(double sueldoBasico)
        {
            double salario=0;
            return salario;
        }

    }
}