// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Entre com a medida (em metros)");
double metros = Convert.ToDouble(Console.ReadLine());
double centimetros = metros * 100;
double quilometros = metros / 1000;
Console.WriteLine("\nEquivalencia");
Console.WriteLine($"{centimetros} cm");
Console.WriteLine($"{metros} m");
Console.WriteLine($"{quilometros} km");
