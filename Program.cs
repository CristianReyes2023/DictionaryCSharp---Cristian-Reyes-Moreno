
/*
    DICTIONARY

    Un diccionario es una estuctura de datos que almacena pares de clave-valor.Cada elemento es un diccionario consiste en una clave única y su correspondiente valor.La clave se utiliza para acceder y recuperar el valor asociado.

    Los diccionarios en C# están implimentados para la clase Dictionary<TKey,TValue>, que se encuentra en el espacio de nombres System.Collections.Generic.Aque, Tkey representa el tipo de datos de la clave y Tvale representa el tipo de datos del valor.

    Caracteristicas.
        -Claves únicas: Cada clave en un diccionario debe ser única. Si se intenta agregar una clave que ya existe, se producira una excepción.
        -Acceso eficiente: Los diccionarios proporcionan un acceso rápido a los valores asociados con una clave.Utilizan una estructura de datos interna llamada tabla hash para logarar un búsqueda eficiente.
        -Operaciones comunes: Los diccionarios en C# admiten operaciones comunes como agregar un elemento, eliminar un elemento,buscar un valor por clave y verificar si una clave existe en el diccionario. 

    TKey => Tipo de claves del diccionario
    TValue => Tipo de los valores del diccionario
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,string> diccionario = new Dictionary<int, string>();

        /*
        Count: Obtiene el número de pares clave-valor incluidos en Dictionary<Tkey,TValue>
        */
        Console.WriteLine("El total de elementos del diccionario es : {0}", diccionario.Count);

        /*
        KEY: Obtiene la colección que contiene las claves de Dictionary<TKey,TValue>
        */

        Dictionary<string,string> openWith = new Dictionary<string, string>();
        //Agregamos algunos elementos al diccionario, no hay llaves duplicada pero hay algunos valores duplicados
        //ADD: Agreg clave y el valor especificados al diccionario 
        openWith.Add("txt","notepad.exe");
        openWith.Add("bmp","paint.exe");
        openWith.Add("dib","paint.exe");
        openWith.Add("rtf","wordpad.exe");

        //El metodo KeyCollection o ValueCollection devuelve una colección ya sea de Key o value
        //VALUE: Obtiene una colección que contiene los valores de Dictionary<TKey,TValue>
        Dictionary<string,string>.ValueCollection  ValueColl = openWith.Values;
        //KEY: Obtiene una colección que contiene las Keys de Dictionary<TKey,TValue>
        Dictionary<string,string>.KeyCollection  keyColl = openWith.Keys;

        foreach(string key in keyColl)
        {
            Console.WriteLine(key);
        }
        /*
        REMOVE: Quita el valor con la clave especificada de Dictionary<TKey,TValue>
        */
        openWith.Remove("dib");
        foreach(string value in ValueColl)
        {
            Console.WriteLine(value);
        }

        foreach(KeyValuePair<string,string> pair in openWith)
        {
            Console.WriteLine("Llave {0} - Valor {1}",pair.Key,pair.Value);
        }
        /*
        CONTAINS KEY: Determina si Dictionary<TKey,TValue> contiene la clave especificada.
        */
        if (openWith.ContainsKey("bmp"))
        {
            Console.WriteLine("El tipo de formato está soportado");
        }

        /*
        CONTAINS VALUE:Determina si Dictionary<TKey,TValue> contiene un valor especifico.
        */
        if(openWith.ContainsValue("notepad.exe"))
        {
            Console.WriteLine("El valor se encuentra registrado");
        }else{
            Console.WriteLine("El valor no se encuentra registrado");
        }
        //CLEAR: Quita todas las claves y valores de Dictionary<TKey,TValue>
        openWith.Clear();
    }
}