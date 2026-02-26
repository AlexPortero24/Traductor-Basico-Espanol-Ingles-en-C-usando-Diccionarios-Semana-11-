using System;// Clase que representa el traductor

public class Traductor// Clase que representa el traductor
{
    private Diccionario diccionario;// Instancia del diccionario que se utilizará para las traducciones

    public Traductor()// Constructor que inicializa el diccionario
    {
        diccionario = new Diccionario();// Inicializa el diccionario
    }

    public string TraducirFrase(string frase)// Método para traducir una frase completa
    {
        string[] palabras = frase.Split(' ');// Divide la frase en palabras utilizando el espacio como separador
        string resultado = "";// Variable para almacenar la frase traducida

        foreach (string palabra in palabras)// Bucle para recorrer cada palabra de la frase
        {
            string limpia = palabra.ToLower().Trim(',', '.', ';', ':');// Limpia la palabra de caracteres especiales y la convierte a minúsculas para facilitar la búsqueda en el diccionario

            if (diccionario.ExistePalabra(limpia))// Verifica si la palabra existe en el diccionario
            {
                resultado += diccionario.ObtenerTraduccion(limpia) + " ";// Si la palabra existe, agrega su traducción al resultado
            }
            else// Si la palabra no existe en el diccionario, la agrega tal cual al resultado
            {
                resultado += palabra + " ";// Agrega la palabra original al resultado
            }
        }

        return resultado.Trim();// Retorna la frase traducida, eliminando cualquier espacio adicional al final
    }

    public void AgregarPalabra(string ingles, string espanol)// Método para agregar una nueva palabra al diccionario
    {
        diccionario.Agregar(ingles, espanol);// Agrega la nueva palabra al diccionario utilizando el método Agregar de la clase Diccionario
    }
}// Fin de la clase Traductor