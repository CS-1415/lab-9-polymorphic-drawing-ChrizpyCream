namespace Lab09
{
    // Abstract base class implementing common properties and methods for 2D graphics.
    // Handles rendering characters with foreground/background colors and defines abstract bounds and hit-testing.
    public abstract class AbstractGraphic2D : IGraphic2D
    {
        // Determines if a given point (x, y) lies within or on the boundary of the shape.
        public abstract bool ContainsPoint(decimal x, decimal y);

        // The minimum X coordinate of the shape's bounding box.
        public abstract decimal LowerBoundX { get; }

        // The maximum X coordinate of the shape's bounding box.
        public abstract decimal UpperBoundX { get; }

        // The minimum Y coordinate of the shape's bounding box.
        public abstract decimal LowerBoundY { get; }

        // The maximum Y coordinate of the shape's bounding box.
        public abstract decimal UpperBoundY { get; }

        // Character used to visually represent the shape when rendered to the console.
        public char DisplayChar { get; set; }

        // Foreground color of the display character.
        public ConsoleColor ForegroundColor { get; set; }

        // Background color of the display character.
        public ConsoleColor BackgroundColor { get; set; }

        // Renders a list of shapes to the console. 
        // Prints a warning if any part of a shape couldn't be rendered due to console buffer limits.
        public static void Display(List<IGraphic2D> shapes)
        {
            bool skippedSome = false;
            foreach (IGraphic2D shape in shapes)
            {
                if (!shape.Display())
                {
                    skippedSome = true;
                }
            }

            if (skippedSome)
            {
                Console.WriteLine("Warning: some cells skipped because of too small buffer");
            }
        }

        // Renders the current shape to the console.
        // Returns true if all intended characters were rendered successfully;
        // returns false if any characters were skipped due to buffer size limitations.
        public bool Display()
        {
            // Set the desired foreground and background colors
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;

            // Convert decimal bounds to integers for console position calculation
            int lowX = (int)decimal.Floor(LowerBoundX);
            int lowY = (int)decimal.Floor(LowerBoundY);
            int highX = (int)decimal.Floor(UpperBoundX);
            int highY = (int)decimal.Floor(UpperBoundY);

            bool skippedSome = false;

            // Loop through each cell within the bounding box
            for (int row = lowY; row <= highY; row++)
            {
                for (int column = lowX; column <= highX; column++)
                {
                    // Check if the current cell is part of the shape
                    if (ContainsPoint(column, row))
                    {
                        // Only draw if within the console buffer size
                        if (column < Console.BufferWidth && row < Console.BufferHeight)
                        {
                            Console.SetCursorPosition(column, row);
                            Console.Write(DisplayChar);
                        }
                        else
                        {
                            skippedSome = true;
                        }
                    }
                }
            }

            // Reset console colors and cursor position after drawing
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);

            return !skippedSome;
        }
    }
}
