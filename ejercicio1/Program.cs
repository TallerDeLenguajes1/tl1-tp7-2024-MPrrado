
using System.Collections.Concurrent;
using EspacioCalculadora; //necesitamos esto para traer el espacio de nombres (el entorno) de nuestra clase para poder acceder
Calculadora instanciaCalculadora = new Calculadora();

static bool operacionCalculadora(Calculadora instanciaCalculadora, bool salir, int opcion)
{
    double termino;
    switch (opcion)
    {
        case 1:
            System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
            if(double.TryParse(Console.ReadLine(), out termino)){
                instanciaCalculadora.Sumar(termino);
            }else{
                System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
            }
            break;

        case 2:
            System.Console.WriteLine("INGRESE EL TERMINO A RESTARSE: ");
            if(double.TryParse(Console.ReadLine(), out termino)){
                instanciaCalculadora.Restar(termino);
            }else{
                System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
            }
            break;

        case 3:
            System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
            if(double.TryParse(Console.ReadLine(), out  termino)){
                instanciaCalculadora.Multiplicar(termino);
            }else{
                System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
            }
            break;

        case 4:
            System.Console.WriteLine("INGRESE EL TERMINO A SUMARSE: ");
            if(double.TryParse(Console.ReadLine(), out  termino)){
                instanciaCalculadora.Dividir(termino);
            }else{
                System.Console.WriteLine("ERROR EL INGRESE UN NUMERO VALIDO");
            }
            break;

        case 5:
            System.Console.WriteLine($"EL RESULTADO FINAL ES: {instanciaCalculadora.Resultado}");
            break;

        case 6:
            instanciaCalculadora.limpiar();
            break;
        
        default:
            Console.WriteLine("saliendo....");
            salir = false;
            break;
    }
    return salir;
}

bool salir = true;
while(salir)
{
    Console.WriteLine("--------MENU CALCUADORA V2.0.0-------");
    Console.WriteLine("1- SUMAR");
    Console.WriteLine("2- RESTAR");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    Console.WriteLine("5- MOSTRAR RESULTADO");
    Console.WriteLine("6- LIMPIAR");
    Console.WriteLine("0- SALIR");
    Console.WriteLine("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion > 5 || opcion < 0)
        {
            Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
        }
        else
        {
            salir = operacionCalculadora(instanciaCalculadora,salir, opcion);
        }
    }
}