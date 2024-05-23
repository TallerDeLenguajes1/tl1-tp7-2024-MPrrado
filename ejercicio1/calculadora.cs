namespace EspacioCalculadora; //analogia con compañeros de clase y otra clase
public class Calculadora
{
    private double dato;

    private double Dato{ //esto no es necesario porque yo PUEDO acceder a las variables que son privadas mientras este dentro de la clase
        get; set;
    }
    

    public double Resultado{ //aqui solo creo la propiedad de Resultado para poder acceder a traver de ella a lo que contiene el resultado que lo alamaceno en dato
        get => Dato;
    }
    public void Sumar(double termino){
        Dato = Dato + termino;
    }
    public void Restar(double termino){
        Dato = Dato - termino;
    }
    public void Multiplicar(double termino){
        Dato = Dato * termino;
    }
    public void Dividir(double termino){
        Dato = Dato + termino;
    }
    public void limpiar(){
        Dato = 0;
    }
}