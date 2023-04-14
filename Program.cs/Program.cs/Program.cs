// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola estudiante PLatzi");


//Programa que calcula el área de un rectángulo.
Double ladoA;
Double ladoB;
Double resultado;

Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("inserte el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("inserte el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El resultado es " + resultado);