//Métodos y propiedades:

using System;

// Length
string miCadena = "Hola, mi nombre es Karen";
int longitud = miCadena.Length;

Console.WriteLine("La longitud de la cadena es: " + longitud);

// Uso de ToUpper()
string texto = "El único modo de hacer un gran trabajo es amar lo que haces - Steve Jobs";
string enMayusculas = texto.ToUpper();

Console.WriteLine("Texto original: " + texto);
Console.WriteLine("Texto en mayúsculas: " + enMayusculas);

// Uso de ToLower()
string textoMinusculas = "\"NUNCA PIENSO EN LAS CONSECUENCIAS DE FALLAR UN GRAN TIRO… CUANDO SE PIENSA EN LAS CONSECUENCIAS SE ESTÁ PENSANDO EN UN RESULTADO NEGATIVO\" - MICHAEL JORDAN";
string enMinusculas = textoMinusculas.ToLower();

Console.WriteLine("Texto original: " + textoMinusculas);
Console.WriteLine("Texto en minúsculas: " + enMinusculas);

// Uso de IndexOf()
string textoIndexOf = "Cuanto más duramente trabajo, más suerte tengo - Gary Player";
int indice = textoIndexOf.IndexOf("ejemplo");

if (indice != -1)
{
    Console.WriteLine("La palabra 'más' comienza en el índice: " + indice);
}
else
{
    Console.WriteLine("La palabra 'más' no se encontró en la cadena.");
}

// Uso de LastIndexOf()
string textoLastIndexOf = "Escoge un trabajo que te guste, y nunca tendrás que trabajar ni un solo día de tu vida - Confucio";
int indiceLast = textoLastIndexOf.LastIndexOf("ejemplo");

if (indiceLast != -1)
{
    Console.WriteLine("La palabra 'trabajo' comienza en el índice: " + indiceLast);
}
else
{
    Console.WriteLine("La palabra 'trabajo' no se encontró en la cadena.");
}
// Uso de Substring()
string textoSubstring = "A veces la adversidad es lo que necesitas encarar para ser exitoso - Zig Ziglar";
string subcadena1 = textoSubstring[5..];
string subcadena2 = textoSubstring[..4];

Console.WriteLine("Subcadena 1: " + subcadena1);
Console.WriteLine("Subcadena 2: " + subcadena2);

// Uso de Replace()
string textoReplace = "Cuando pierdas, no pierdas la lección - Dalai Lama \r\n";
string textoModificado = textoReplace.Replace("pierdas", "piedras");

Console.WriteLine("Texto original: " + textoReplace);
Console.WriteLine("Texto modificado: " + textoModificado);

// Uso de Trim()
string textoConEspacios = "No busques los errores, busca un remedio - Henry Ford";
string textoSinEspacios = textoConEspacios.Trim();

Console.WriteLine("Texto original: '" + textoConEspacios + "'");
Console.WriteLine("Texto sin espacios: '" + textoSinEspacios + "'");
{
    Console.WriteLine("Texto original: '" + "No busques los errores, busca un remedio - Henry Ford" + "'");
    Console.WriteLine("Texto sin espacios: '" + "No busques los errores, busca un remedio - Henry Ford".Replace(" ", "") + "'");

    // Uso de StartsWith()
    string textoStartsWith = "Si te caíste ayer, levántate hoy - H. G. Wells";
    bool empiezaConHola = textoStartsWith.StartsWith("Hola");

    if (empiezaConHola)
    {
        Console.WriteLine("La cadena comienza con 'Si'.");
    }
    else

        Console.WriteLine("La cadena no comienza con 'Si'.");
    // Uso de EndsWith()
    string textoEndsWith = "Haz de cada día tu obra maestra John Wooden";
    bool terminaConMundo = textoEndsWith.EndsWith("Mundo");

    if (terminaConMundo)
    {
        Console.WriteLine("La cadena termina con 'Wooden'.");
    }
    else
    {
        Console.WriteLine("La cadena no termina con 'Wooden'.");
    }

    // Uso de Split()
    string textoSplit = "Rojo,Amarillo,Azul";
    string[] colores = textoSplit.Split(',');

    Console.WriteLine("Los colores son:");
    foreach (string color in colores)
    {
        Console.WriteLine(color);
    }

    // Uso de ToCharArray()
    string textoToCharArray = "El mejor momento del día es ahora - Pierre Bonnard";
    char[] caracteres = textoToCharArray.ToCharArray();

    Console.WriteLine("Los caracteres en la cadena son:");
    foreach (char c in caracteres)
    {
        Console.WriteLine(c);
    }
}
   



