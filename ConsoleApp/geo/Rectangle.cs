using ConsoleApp;

public class Rectangle : Shape2D
{

    public int Height { get; set; }
    public int Weight { get; set; }
    
    public void Draw()
    {
        Console.WriteLine("Dikdörtgen çizildi.");
        Console.WriteLine("Alanı:" + CalculateArea());
    }

    public double CalculateArea()
    {
        return Height * Weight;
    }
}