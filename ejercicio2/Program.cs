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

for(int i = 0; i < trabajadores.Length; i++)
{
    trabajadores[i] = new Empleado();
    trabajadores[i].Cargo = Cargos.Ingeniero; //seleccionamos el tipo Cargos como muestra esta linea
    trabajadores[i].FechaIngreso = new DateTime(anioIngreso.Next(2000,2024), mes.Next(1,12), dia.Next(1,31)); 
    trabajadores[i].FechaNacimiento = new DateTime(anioNacimiento.Next(1970,1985), mes.Next(1,12), dia.Next(1,31)); 
    trabajadores[i].Nombre = nombres[indice.Next(2)];
    trabajadores[i].Apellido = apellidos[indice.Next(2)];
    trabajadores[i].SueldoBasico = sueldoBasico.Next(15000000,50000000)/100; 
    trabajadores[i].EstadoCivil = estadoCivil[indiceEstadoCivil.Next(1)];
    
}