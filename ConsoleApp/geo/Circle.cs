using ConsoleApp;

public class Circle : Shape2D
{
    public static double PI = 3.14; //Class Member
    public double Radius { get; set; } //Instance Member
    
    public void Draw()
    {
        Console.WriteLine("Daire çizildi.");
        Console.WriteLine("Alanı: " + CalculateArea());
    }

    public double CalculateArea()
    {
        return PI * Radius * Radius;
    }
}