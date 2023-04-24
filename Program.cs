using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        int eleccion=Menu();
        while(eleccion<5){
            switch(eleccion){
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
            }
            eleccion=Menu();
        }  
    }
    static void Inscripcion(){
        string dni, nombre=IngresarString("Ingresar tu nombre"), apellido=IngresarString("Ingresar tu apellido");
        int tipoEntrada, valorRequerido, valorAbonado;
        do{
            dni=IngresarString("Ingresar el DNI");

        }while(dni.Length!=8 && !int.TryParse(dni,out int x));
        do{
        tipoEntrada=IngresarInt("Ingresar el tipo de entrada: \n Opción 1 - Día 1 , valor a abonar $15000 \n Opción 2 - Día 2, valor a abonar $30000 \n Opción 3 - Día 3, valor a abonar $10000 \n Opción 4 - Full Pass, valor a abonar $40000");
        }while(tipoEntrada>4 || tipoEntrada<1);
        

        



    }
    static int Menu(){
        Console.WriteLine("1- Nueva Inscripción");
        Console.WriteLine("2- Obtener Estadísticas del Evento");
        Console.WriteLine("3- Buscar Cliente");
        Console.WriteLine("4- Cambiar entrada de un Cliente");
        Console.WriteLine("5- Salir");
        int eleccion=IngresarInt("");
        return eleccion;
    }
    static int IngresarInt(string mensaje){
        Console.WriteLine(mensaje);
        int num=int.Parse(Console.ReadLine());
        return num;
    }
    static string IngresarString(string mensaje){
        Console.WriteLine(mensaje);
        string frase=Console.ReadLine();
        return frase;
    }
}