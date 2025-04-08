namespace Lab09;

public class Rectangle : AbstractGraphic2D
{

    public decimal Left;
    public decimal Top;
    public decimal Width;
    public decimal Height;
    public Rectangle(decimal Left, decimal Top, decimal Width, decimal Height)
    {
        this.Left = Left;
        this.Top = Top;
        this.Width = Width;
        this.Height = Height;
    }
    public override decimal LowerBoundX => Left;

    public override decimal UpperBoundX => Left+Width;

    public override decimal LowerBoundY => Top;

    public override decimal UpperBoundY => Top+Height;
    public override bool ContainsPoint(decimal x, decimal y)
    {
        if (x >= Left && x <= Left+Width && y >= Top && y <= Top+Height)
            return true;
        else 
            return false;
    }
}