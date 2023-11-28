using System;

class ResistorOhmsCalculator
{
    static void Main()
    {
        Console.WriteLine("Resistor Ohms Calculator");

        string[] colorCodes = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "gray", "white" };
        int[] colorValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("Enter the first color: ");
        string color1 = Console.ReadLine().ToLower();
        Console.Write("Enter the second color: ");
        string color2 = Console.ReadLine().ToLower();
        Console.Write("Enter the third color: ");
        string color3 = Console.ReadLine().ToLower();
        Console.Write("Enter the fourth color: ");
        string color4 = Console.ReadLine().ToLower();

        int value1 = Array.IndexOf(colorCodes, color1);
        int value2 = Array.IndexOf(colorCodes, color2);
        int multiplier = (int)Math.Pow(10, Array.IndexOf(colorCodes, color3));
        double tolerance = color4 == "gold" ? 5 : (color4 == "silver" ? 10 : 20); // Tolerance values for gold, silver, and none

        double resistance = (value1 * 10 + value2) * multiplier;

        Console.WriteLine($"Resistance: {resistance} ohms +/- {tolerance}% tolerance");
    }
}
