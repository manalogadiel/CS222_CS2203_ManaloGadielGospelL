using System;

Console.Write("Enter amount in USD: ");
double usd = double.Parse(Console.ReadLine());

Console.Write("Enter exchange rate from USD to EUR: ");
double rate = double.Parse(Console.ReadLine());

double eur = usd * rate;

Console.WriteLine($"Amount in EUR: {eur:F2}");

