using System.Collections.Generic;// Clase que representa el diccionario de traducción

public class Diccionario // Clase que representa el diccionario de traducción
{
    private Dictionary<string, string> palabras; // Diccionario que almacena las palabras en inglés y su traducción al español

    public Diccionario()// Constructor que inicializa el diccionario con algunas palabras comunes
    {
        palabras = new Dictionary<string, string>();// Inicializa el diccionario

        // Palabras iniciales
        palabras.Add("tiempo", "time");// Agrega la palabra "tiempo" con su traducción "time" al diccionario
        palabras.Add("persona", "person");// Agrega la palabra "persona" con su traducción "person" al diccionario
        palabras.Add("año", "year");// Agrega la palabra "año" con su traducción "year" al diccionario
        palabras.Add("camino", "way");// Agrega la palabra "camino" con su traducción "way" al diccionario
        palabras.Add("dia", "day");// Agrega la palabra "día" con su traducción "day" al diccionario
        palabras.Add("cosa", "thing");// Agrega la palabra "cosa" con su traducción "thing" al diccionario
        palabras.Add("hombre", "man");// Agrega la palabra "hombre" con su traducción "man" al diccionario
        palabras.Add("mundo", "world");// Agrega la palabra "mundo" con su traducción "world" al diccionario
        palabras.Add("vida", "life");// Agrega la palabra "vida" con su traducción "life" al diccionario
        palabras.Add("mano", "hand");// Agrega la palabra "mano" con su traducción "hand" al diccionario
        palabras.Add("parte", "part");// Agrega la palabra "parte" con su traducción "part" al diccionario
        palabras.Add("niño", "child");// Agrega la palabra "niño" con su traducción "child" al diccionario
        palabras.Add("ojo", "eye");// Agrega la palabra "ojo" con su traducción "eye" al diccionario
        palabras.Add("mujer", "woman");// Agrega la palabra "mujer" con su traducción "woman" al diccionario
        palabras.Add("lugar", "place");// Agrega la palabra "lugar" con su traducción "place" al diccionario
        palabras.Add("trabajo", "work");// Agrega la palabra "trabajo" con su traducción "work" al diccionario
        palabras.Add("semana", "week");// Agrega la palabra "semana" con su traducción "week" al diccionario
        palabras.Add("caso", "case");// Agrega la palabra "caso" con su traducción "case" al diccionario
        palabras.Add("punto", "point");// Agrega la palabra "punto" con su traducción "point" al diccionario
        palabras.Add("gobierno", "government");// Agrega la palabra "gobierno" con su traducción "government" al diccionario
        palabras.Add("empresa", "company");// Agrega la palabra "empresa" con su traducción "company" al diccionario
    }

    public void Agregar(string ingles, string espanol)// Método para agregar una nueva palabra al diccionario
    {
        if (!palabras.ContainsKey(ingles))// Verifica si la palabra en inglés no existe en el diccionario
        {
            palabras.Add(ingles, espanol);// Agrega la nueva palabra al diccionario
        }
    }

    public bool ExistePalabra(string palabra)// Método para verificar si una palabra existe en el diccionario
    {
        return palabras.ContainsKey(palabra);// Retorna true si la palabra existe, de lo contrario retorna false
    }

    public string ObtenerTraduccion(string palabra)// Método para obtener la traducción de una palabra
    {
        return palabras[palabra];// Retorna la traducción de la palabra
    }
}// Fin de la clase Diccionario