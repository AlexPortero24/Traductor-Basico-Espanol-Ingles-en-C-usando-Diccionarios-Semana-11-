using System;// Clase principal del programa

class Program// Clase principal del programa
{
    static void Main(string[] args)// Método principal del programa
    {
        Traductor traductor = new Traductor();// Crea una instancia del traductor
        int opcion;// Variable para almacenar la opción seleccionada por el usuario

        do// Bucle para mostrar el menú hasta que el usuario decida salir
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());// Lee la opción seleccionada por el usuario y la convierte a entero
            Console.WriteLine();// Imprime una línea en blanco para mejorar la legibilidad

            switch (opcion)// Estructura de control para manejar las diferentes opciones del menú
            {
                case 1:// Opción para traducir una frase
                    Console.Write("Ingrese una frase: ");// Solicita al usuario que ingrese una frase
                    string frase = Console.ReadLine();// Lee la frase ingresada por el usuario
                    string resultado = traductor.TraducirFrase(frase);// Traduce la frase ingresada por el usuario utilizando el traductor
                    Console.WriteLine("Traducción: " + resultado);// Muestra la traducción de la frase ingresada por el usuario
                    break;// Fin del caso 1

                case 2:// Opción para agregar palabras al diccionario
                    Console.Write("Ingrese palabra en español: ");// Solicita al usuario que ingrese una palabra en español
                    string espanol = Console.ReadLine().ToLower();// Lee la palabra en español ingresada por el usuario y la convierte a minúsculas

                    Console.Write("Ingrese traducción en ingles: ");// Solicita al usuario que ingrese la traducción en inglés
                    string ingles = Console.ReadLine().ToLower();// Lee la traducción en inglés ingresada por el usuario y la convierte a minúsculas

                    traductor.AgregarPalabra(espanol, ingles);// Agrega la nueva palabra al diccionario utilizando el traductor
                    Console.WriteLine("Palabra agregada correctamente.");// Muestra un mensaje indicando que la palabra se ha agregado correctamente
                    break;// Fin del caso 2

                case 0:// Opción para salir del programa
                    Console.WriteLine("Saliendo...");// Muestra un mensaje indicando que el programa se está cerrando
                    break;// Fin del caso 0

                default:// Opción para manejar entradas inválidas
                    Console.WriteLine("Opción inválida.");// Muestra un mensaje indicando que la opción seleccionada no es válida
                    break;// Fin del caso default
            }

            Console.WriteLine();// Imprime una línea en blanco para mejorar la legibilidad antes de mostrar el menú nuevamente

        } while (opcion != 0);// Fin del bucle do-while que muestra el menú hasta que el usuario decida salir
    }
}// Fin de la clase Program