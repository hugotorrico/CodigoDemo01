// See https://aka.ms/new-console-template for more information

var nombresDinamica = "Hugo Torrico";
var edadDinamica = 36;
//Declaración de las variables
//TipoDato NombreVariable ;
string nombres;
int edad;
float sueldo;
bool esCasado;

nombres = "Hugo Felipe";
edad = 36;
sueldo = 9500.10f;
esCasado = true;


//Declaración de las variables e inicializar valores
string apellidos = "Torrico Marquez";
String apellidosClase = "Torrico Marquez";

bool esSoltero = false;
Boolean esNuevo = true;

int annio = 2024;
decimal descuento = 0.18m;
var suma = nombresDinamica + edadDinamica;

//Fecha
DateTime fechaDeHoy = DateTime.Now;



if (edad > 18) 
{
    Console.WriteLine("Es Mayor de Edad");
}
else
{
    Console.WriteLine("Es Menor de Edad");
}

if (sueldo>1000)
{
    Console.WriteLine("Eres Millonario");
}
else
{
    Console.WriteLine("No eres millonario");
}






/*
Console.WriteLine(fechaDeHoy);
Console.WriteLine(fechaDeHoy.ToLongDateString());
Console.WriteLine(fechaDeHoy.ToShortDateString());

Console.WriteLine(suma);
Console.WriteLine(nombresDinamica);
Console.WriteLine(edadDinamica);

Console.WriteLine(nombres);
Console.WriteLine(edad);
Console.WriteLine(sueldo);
Console.WriteLine(esCasado);

Console.WriteLine(apellidos);
Console.WriteLine(annio);
Console.WriteLine(descuento);
Console.WriteLine(esSoltero);
*/

//Console.WriteLine("Hello, World!");
//Console.Read();


