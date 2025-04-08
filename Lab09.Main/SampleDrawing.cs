using Lab09;

List<IGraphic2D> shapes = new List<IGraphic2D> {
    new Circle(10, 10, 5) { BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' ' },
    new Circle(8, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
    new Circle(12, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
    new Circle(8, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
    new Circle(12, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
    new Rectangle(8, 13, 4, 0.5m) { ForegroundColor = ConsoleColor.DarkGray, DisplayChar = 'v' },
    new Rectangle(8, 16, 4, 10) { ForegroundColor = ConsoleColor.DarkGreen, DisplayChar = '#' }
};

Console.Clear();
AbstractGraphic2D.Display(shapes);