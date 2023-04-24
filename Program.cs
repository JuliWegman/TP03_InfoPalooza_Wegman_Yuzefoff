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
        }  
    }
    static void Inscripcion(){


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
}