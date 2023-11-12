public class ColorPrinter
{
    Random rand = new Random();
    ConsoleColor GetRandomColor() => (ConsoleColor)rand.Next(1, 16);

    /*
        Subscribe to the event with a method, name does not mater
    */
    XmasTree publisher;
    internal void Subscribe(XmasTree publisher)
    {
        this.publisher = publisher;
        publisher.DataSent += PrintDataSendt;
    }

    private void PrintDataSendt(string data)
    {
        if (publisher.CurrentSubscriber == "ColorPrinter" || publisher.CurrentSubscriber == "Any")
        {
            foreach (char ch in data)
            {
                if (ch == 'o')
                    PrintColoredChar(ch);
                else
                    Console.Write(ch);
            }
            Console.WriteLine();
        }
    }

    // Function to print a character in a random color
    void PrintColoredChar(char ch)
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        Console.ForegroundColor = GetRandomColor();
        Console.Write(ch);
        Console.ForegroundColor = originalColor;
    }
}