namespace ConsoleApp.geo;

public class Cylinder : Circle, Shape3D
{

    public double Height { get; set; }
    
    public void Draw()
    {
        Console.WriteLine("Cylinder çizildi.");
        Console.WriteLine("Alanı: " + CalculateArea());
        Console.WriteLine("Hacmi: " + CalculateVolume());
    }

    public new double CalculateArea()
    {
        return (2 * PI * Radius) * Height + 2 * base.CalculateArea();
    }

    public double CalculateVolume()
    {
        return base.CalculateArea() * Height;
    }
}