// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

var radio = 1.1;
var resultado = 0d;

const double Pi = 3.14;

Console.WriteLine("Bienvenido, calculemos círculos!");
// Pi * radio*radio
Console.WriteLine("Ingrese el valor del radio");

radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;
Console.WriteLine("El área de tu círculo es " + resultado);