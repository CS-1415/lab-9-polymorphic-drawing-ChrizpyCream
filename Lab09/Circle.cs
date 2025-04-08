namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public decimal CenterX;
    public decimal CenterY;
    public decimal Radius;
    public Circle(decimal CenterX, decimal CenterY, decimal Radius)
    {
        this.CenterX = CenterX;
        this.CenterY = CenterY;
        this.Radius = Radius;
    }
    public override decimal LowerBoundX => CenterX - Radius;

    public override decimal UpperBoundX => CenterX + Radius;

    public override decimal LowerBoundY => CenterY - Radius;

    public override decimal UpperBoundY => CenterY + Radius;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if ((x - CenterX)*(x - CenterX) + (y - CenterY) * (y - CenterY) <= Radius * Radius)
            return true;
        else
            return false;
    }
}