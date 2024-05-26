using System.Runtime.CompilerServices;
using Empleados;

Empleado[] trabajadores = new Empleado[3];  // asi es como declaramos 3 instancias (QUE NO ESTAN INSTANCIADAS) de nuestra clase Empleados
string[] nombres = {"Juan", "Pedro", "Matias"};
string[] apellidos = {"Perez", "Sanchez", "Prado"};
char[] estadoCivil = {'s', 'c'};
Random indice = new Random();
Random sueldoBasico = new Random();
Random indiceEstadoCivil = new Random();
Random anioNacimiento = new Random();
Random anioIngreso = new Random();
Random mes = new Random();
Random dia = new Random();
double totalGastosSueldos=0;
for(int i = 0; i < trabajadores.Length; i++)
{
    trabajadores[i] = new Empleado();
    trabajadores[i].Cargo = Cargos.Ingeniero; //seleccionamos el tipo Cargos como muestra esta linea
    trabajadores[i].FechaIngreso = new DateTime(anioIngreso.Next(2000,2024), mes.Next(1,12), dia.Next(1,31)); 
    trabajadores[i].FechaNacimiento = new DateTime(anioNacimiento.Next(1970,1985), mes.Next(1,12), dia.Next(1,31)); 
    trabajadores[i].Nombre = nombres[indice.Next(0,2)];
    trabajadores[i].Apellido = apellidos[indice.Next(0,2)];
    trabajadores[i].SueldoBasico = Math.Round(sueldoBasico.NextDouble() * (500000-150000) + 150000,2); 
    trabajadores[i].EstadoCivil = estadoCivil[indiceEstadoCivil.Next(0,1)];
    totalGastosSueldos = totalGastosSueldos + trabajadores[i].CalcularSalario();

    //tambien puedo hacer de la forma simplificada
    // trabajadores[i] = new Empleado(){

    //     Cargo = Cargos.Ingeniero; //seleccionamos el tipo Cargos como muestra esta linea
    //     FechaIngreso = new DateTime(anioIngreso.Next(2000,2024), mes.Next(1,12), dia.Next(1,31)); 
    //     FechaNacimiento = new DateTime(anioNacimiento.Next(1970,1985), mes.Next(1,12), dia.Next(1,31)); 
    //     Nombre = nombres[indice.Next(0,2)];
    //     Apellido = apellidos[indice.Next(0,2)];
    //     SueldoBasico = Math.Round(sueldoBasico.NextDouble() * (500000-150000) + 150000,2); 
    //     EstadoCivil = estadoCivil[indiceEstadoCivil.Next(0,1)];
    // }
}

//mostramos los campos de cada empleado
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("----------DATOS EMPLEADOS----------");
for(int i = 0; i < trabajadores.Length; i++)
{
    trabajadores[i].mostrarEmpleado(i);
}

//mostramos gastos totales en caracter de salarios
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"-----Gastos totales en caracter de salarios: ${totalGastosSueldos}");

//buscamos el empleado mas proximo de la jubilacion
int indiceProxJubilo = 0;
int checkVar =0 ;
for (int i=0; i < trabajadores.Length; i++)
{
    if (trabajadores[i].EdadEmpleado() > checkVar)
    {
        checkVar = trabajadores[i].EdadEmpleado();
        indiceProxJubilo = i;
    }
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("--------------EMPLEADO PROXIMO A JUBILARSE--------------");
trabajadores[indiceProxJubilo].mostrarEmpleado(indiceProxJubilo);

